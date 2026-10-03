using System.Collections.Generic;

public static class UpdateController
{
	private static readonly List<PriorityDataUpdate>[] updateBuckets;

	private static readonly List<PriorityDataFixedUpdate>[] fixedUpdateBuckets;

	private static readonly List<PriorityDataLateUpdate>[] lateUpdateBuckets;

	public static void AddUpdateObject(IUpdatecontrollerSubscriberUpdate obj, UpdatePriority priority, int conditionInp = 1)
	{
	}

	public static void AddFixedUpdateObject(IUpdatecontrollerSubscriberFixedUpdate obj, UpdatePriority priority, int conditionInp = 1)
	{
	}

	public static void AddLateUpdateObject(IUpdatecontrollerSubscriberLateUpdate obj, UpdatePriority priority, int conditionInp = 1)
	{
	}

	public static void RemoveUpdateObject(IUpdatecontrollerSubscriberUpdate obj)
	{
	}

	public static void RemoveFixedUpdateObject(IUpdatecontrollerSubscriberFixedUpdate obj)
	{
	}

	public static void RemoveLateUpdateObject(IUpdatecontrollerSubscriberLateUpdate obj)
	{
	}

	public static void Update()
	{
	}

	private static void UpdateList(int state, List<PriorityDataUpdate> priorityDatas)
	{
	}

	public static void FixedUpdate()
	{
	}

	private static void FixedUpdateList(int state, List<PriorityDataFixedUpdate> priorityDatas)
	{
	}

	public static void LateUpdate()
	{
	}

	private static void LateUpdateList(int state, List<PriorityDataLateUpdate> priorityDatas)
	{
	}

	public static void Clear()
	{
	}

	private static int GetPresentState()
	{
		return 0;
	}
}
