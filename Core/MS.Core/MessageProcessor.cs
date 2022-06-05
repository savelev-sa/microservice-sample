namespace MS.Core;

public class MessageProcessor<TMessage>
{
	private readonly TMessage _message;
	private readonly CancellationToken _cancellationToken;

	public MessageProcessor(TMessage message, CancellationToken cancellationToken)
	{
		_message = message;
		_cancellationToken = cancellationToken;
	}

	public Task Invoke<TMessageHandler>() where TMessageHandler : BaseHandler<TMessage>, new()
	{
		var handler =  new TMessageHandler();

		handler.Query(_message, _cancellationToken);

		return handler.Invoke(_message, _cancellationToken);
	}

	public Task<TResult> Invoke<TMessageHandler, TResult>()
		where TMessageHandler : BaseHandlerWithResult<TMessage, TResult>, new()
	{
		var handler =  new TMessageHandler();

		handler.Query(_message, _cancellationToken);

		return handler.Invoke(_message, _cancellationToken);
	}
}