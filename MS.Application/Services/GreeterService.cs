using MS.Contracts.Grpc;
using MS.Contracts.Grpc.Models;
using MS.Core;
using MS.Domain.Handlers;
using ProtoBuf.Grpc;

namespace MS.Application.Services
{
    public class GreeterService : IGreeterService
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly MessageProcessorFactory _messageProcessorFactory;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
            _messageProcessorFactory = new MessageProcessorFactory();
        }

        public Task<HelloReply> SayHelloAsync(HelloRequest request, CallContext context = default)
            => _messageProcessorFactory
                .Process(request, context.CancellationToken)
                .Invoke<HelloRequestHandler, HelloReply>();
    }
}