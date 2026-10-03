using System.Collections.Generic;

public class ThreadSafeQueue<T>
{
	private Queue<T> _queue;

	private object _lock;

	private Queue<T> Queue => null;

	public int Count => 0;

	public ThreadSafeQueue(int initialCap)
	{
	}

	public void Clear()
	{
	}

	public T Dequeue()
	{
		return default;
	}

	public void Enqueue(T a)
	{
	}

	public T Peek()
	{
		return default;
	}
}
