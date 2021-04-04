using Grpc.Core;

using GrpcService;

using System.Threading.Tasks;

namespace GrpcProto.Service
{
	public class HelloService : Greeter.GreeterClient
	{
		#region Overrides of GreeterClient

		public override AsyncUnaryCall<HelloReply> SayHelloAsync(HelloRequest request, CallOptions options)
		{
			HelloReply response = new() { Message = $"Привет, {request.Name}" };
			return new AsyncUnaryCall<HelloReply>(Task.FromResult(response), default, default, default, default);
		}

		#endregion
	}
}