using System.Collections;
using System.Collections.Generic;

public class DictionaryWithChangeEvent<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	public delegate void OnDictionaryChangeDelegate(IDictionary<TKey, TValue> dictionary);

	private IDictionary<TKey, TValue> dictionary;

	public OnDictionaryChangeDelegate OnDictionaryChange;

	public bool IsReadOnly => false;

	public int Count => 0;

	public ICollection<TKey> Keys => null;

	public ICollection<TValue> Values => null;

	public TValue this[TKey key]
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public void Add(KeyValuePair<TKey, TValue> pair)
	{
	}

	public void Add(TKey key, TValue value)
	{
	}

	public bool Remove(KeyValuePair<TKey, TValue> pair)
	{
		return false;
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool Contains(KeyValuePair<TKey, TValue> pair)
	{
		return false;
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	public IEnumerator GetEnumerator()
	{
		return null;
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	private void NotifyDictionaryChange()
	{
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default;
		return false;
	}
}
