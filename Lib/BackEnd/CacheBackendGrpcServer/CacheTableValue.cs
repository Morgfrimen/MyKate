using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

using CommonModels;

namespace CacheBackendGrpcServer
{
    public sealed class CacheTableValue
    {
#region Static Fields and Constants

        private static CacheTableValue _cacheTableValue;

#endregion

#region Constructors

        private CacheTableValue() { }

#endregion

#region Properties

        public ConcurrentBag<TableValueModel> TableValueModels { get; set; }

#endregion

#region Methods

        public bool AddCell(TableValueModel tableValueModel)
        {
            try
            {
                TableValueModels.Add(tableValueModel);

                return true;
            }
            catch
            {
                Debug.Print("Ошибка добавления элемента в модель таблицы");

                return false;
            }
        }

        public bool AddRangeCell(IList<TableValueModel> tableValueModels)
        {
            try
            {
                foreach (TableValueModel tableValueModel in tableValueModels) TableValueModels.Add(tableValueModel);

                return true;
            }
            catch
            {
                Debug.Print("Ошибка добавления списка элементов в модель таблицы");

                return false;
            }
        }

        public static CacheTableValue GetCache() => _cacheTableValue ??= new();

#endregion
    }
}