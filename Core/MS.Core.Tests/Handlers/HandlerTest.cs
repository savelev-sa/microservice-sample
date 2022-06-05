using MS.Core.Tests.Handlers.Models;

namespace MS.Core.Tests.Handlers;

[TestFixture]
public class HandlerTest
{
	private MessageProcessorFactory _processFactory;
	private TestHandlerMessage _message;

	[SetUp]
	public void SetUp()
	{
		_processFactory = new MessageProcessorFactory();
		_message = new TestHandlerMessage();
	}

	[Test]
	public async Task Invoke_Ok()
	{
		await _processFactory.Process(_message, CancellationToken.None)
			.Invoke<TestHandler>();
	}

	[Test]
	public async Task InvokeWithResult_Ok()
	{
		var result = await _processFactory.Process(_message, CancellationToken.None)
			.Invoke<TestHandlerWithResult, int>();

		Assert.That(_message.SomeData + 1, Is.EqualTo(result));
	}
}