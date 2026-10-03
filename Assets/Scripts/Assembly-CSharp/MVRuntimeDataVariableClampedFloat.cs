using System.Collections.Generic;

public class MVRuntimeDataVariableClampedFloat : MVRuntimeDataVariable<float>
{
	private float min;

	private float max;

	public override float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public MVRuntimeDataVariableClampedFloat(string variableId, float sendInterval, Dictionary<object, object> initialRuntimeData, bool writeThrough, float min, float max)
		: base((string)null, 0f, (Dictionary<object, object>)null, false)
	{
	}
}
