using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class MVRuntimeDataVariable
{
	public delegate void OnChangeDelegate(object newValue);

	public delegate void OnWriteThroughDelegate(object newValue);

	private ObscuredString variableId;

	private object value;

	private object sendValue;

	private float sendInterval;

	private float lastSendTime;

	private bool writeThrough;

	public OnChangeDelegate OnChange;

	public OnWriteThroughDelegate OnWriteThrough;

	public bool WriteThrough => false;

	public object Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MVRuntimeDataVariable(string variableId, float sendInterval, Dictionary<object, object> initialRuntimeData, bool writeThrough)
	{
	}

	public void Receive(Dictionary<object, object> runtimeDataDelta)
	{
	}

	public void Send(ref Dictionary<object, object> runtimeDataDelta, bool immediateSend)
	{
	}

	private void NotifyChange()
	{
	}
}
public class MVRuntimeDataVariable<T> : MVRuntimeDataVariable
{
	public new virtual T Value
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public MVRuntimeDataVariable(string variableId, float sendInterval, Dictionary<object, object> initialRuntimeData, bool writeThrough)
		: base(null, 0f, null, writeThrough: false)
	{
	}
}
