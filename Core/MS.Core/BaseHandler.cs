namespace MS.Core
{
	public abstract class BaseHandler<TMessage>
	{
		protected internal virtual Task Query(TMessage message, CancellationToken cancellationToken) => Task.CompletedTask;

		protected internal abstract Task Invoke(TMessage message, CancellationToken cancellationToken);
	}
}