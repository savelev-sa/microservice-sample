namespace MS.Core.Tests.Handlers.Models;

public class TestHandlerWithResult : BaseHandlerWithResult<TestHandlerMessage, int>
{
	protected override Task<int> Invoke(TestHandlerMessage message, CancellationToken cancellationToken)
		=> Task.FromResult(message.SomeData + 1);
}