using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using CacheBackendGrpcServer;

using CommonModels;

using Grpc.Core;

using Table;

namespace GrpcProtoClient.Service
{
    public sealed class TableValueService : TableService.TableServiceBase
    {
#region Methods

        private static Task<bool> ChangeList(IList<TableValueModel> tableValueModel) => Task.Run
        (
            () =>
            {
                try
                {
                    CacheTableValue.GetCache()
                                .TableValueModels.Clear();

                    foreach (TableValueModel valueModel in tableValueModel)
                    {
                        CacheTableValue.GetCache()
                                    .TableValueModels.Add(valueModel);
                    }
                }
                catch (Exception)
                {
                    //TODO:Logger
                    return false;
                }

                return true;
            }
        );

#region Overrides of TableServiceBase

        public override Task<GetTableValueResponse> GetTableValue(GetTableValueRequest request, ServerCallContext context)
        {
            GetTableValueResponse response = new();

            try
            {
                TableValueModel tableValueModel = CacheTableValue.GetCache()
                                                              .TableValueModels.FirstOrDefault(item => item.RowIndex == request.RowTable && item.ColumnIndex == request.ColumnIndex);
                response.ResponseType = ResponseType.ResponseOk;
                response.Value = tableValueModel.Value;
            }
            catch (Exception)
            {
                response.ResponseType = ResponseType.ResponseServererror;
                response.Value = default;
            }

            return Task.FromResult(response);
        }

        public override async Task<TableResponse> ChangeTableValue(TableRequest request, ServerCallContext context)
        {
            TableResponse response = new();

            try
            {
                TableValueModel tableModel = new() {RowIndex = request.RowTable, ColumnIndex = request.ColumnIndex, Value = request.Value};

                if (await ConcatAsync(tableModel))
                {
                    if (!CacheTableValue.GetCache()
                                     .AddCell(tableModel))
                        throw new Exception("Ошибка добавления элемента в список");
                }
                else
                {
                    IList<TableValueModel> list = CacheTableValue.GetCache()
                                                              .TableValueModels.Select
                                                                  (
                                                                      item => item.RowIndex == tableModel.RowIndex && item.ColumnIndex == tableModel.ColumnIndex
                                                                                  ? new TableValueModel {RowIndex = item.RowIndex, ColumnIndex = item.ColumnIndex, Value = tableModel.Value}
                                                                                  : item
                                                                  )
                                                              .ToList();

                    if (!await ChangeList(list)) throw new Exception("Не удалось обновить элемент");
                }

                response.ResponseType = ResponseType.ResponseOk;
                response.RowTable = request.RowTable;
                response.ColumnIndex = request.ColumnIndex;
                response.Value = request.Value;
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                response.ResponseType = ResponseType.ResponseServererror;
                response.Value = default;
            }

            return response;
        }

#endregion

        private static Task<bool> ConcatAsync(TableValueModel tableValueModel) => Task.Run
        (
            () => CacheTableValue.GetCache()
                              .TableValueModels.Contains(tableValueModel)
        );

#endregion
    }
}