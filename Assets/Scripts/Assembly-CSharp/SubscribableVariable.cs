public class SubscribableVariable<T> : SubscribableVariableBase<T>
{
	public T ValueSet
	{
		set
		{
		}
	}

	public SubscribableVariable(T value)
		: base(default(T))
	{
	}
}
