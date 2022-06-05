namespace MS.Core.Tests.Handlers.Models;

public class TestHandler : BaseHandler<TestHandlerMessage>
{
	protected override Task Invoke(TestHandlerMessage message, CancellationToken cancellationToken)
		=> Task.CompletedTask;
}