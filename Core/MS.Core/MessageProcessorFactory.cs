namespace MS.Core
{
	public class MessageProcessorFactory
	{
		public MessageProcessor<TMessage> Process<TMessage>(TMessage message, CancellationToken cancellationToken)
			=> new(message, cancellationToken);
	}
}