using System.ServiceModel;
using System.Threading.Tasks;
using MS.Contracts.Grpc.Models;
using ProtoBuf.Grpc;

namespace MS.Contracts.Grpc
{
	[ServiceContract]
	public interface IGreeterService
	{
		[OperationContract]
		Task<HelloReply> SayHelloAsync(HelloRequest request,
			CallContext context = default);
	}
}