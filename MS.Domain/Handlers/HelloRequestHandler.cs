using MS.Contracts.Grpc.Models;
using MS.Core;

namespace MS.Domain.Handlers;

public class HelloRequestHandler : BaseHandlerWithResult<HelloRequest, HelloReply>
{
	protected override Task<HelloReply> Invoke(HelloRequest message, CancellationToken cancellationToken)
	{
		return Task.FromResult(new HelloReply
		{
			Message = "Hello " + message.Name
		});
	}
}