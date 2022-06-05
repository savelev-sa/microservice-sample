namespace MS.Core
{
	public abstract class BaseHandlerWithResult<TMessage, TResult> : BaseHandler<TMessage>
	{
		protected internal abstract override Task<TResult> Invoke(TMessage message, CancellationToken cancellationToken);
	}
}