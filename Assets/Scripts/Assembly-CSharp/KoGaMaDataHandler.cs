using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine.Events;

public static class KoGaMaDataHandler
{
	private class AsyncBookkeeping
	{
		private float workStartTime;

		private readonly UnityAction<int> doneCallback;

		public int deserializedPrototypes;

		public int deserializedWorldObjects;

		public int deserializedLinks;

		public int deserializedObjectLinks;

		public int numberOfPrototypes;

		public int numberOfWorldObjects;

		public int numberOfLinks;

		public int numberOfObjectLinks;

		public int rootId;

		public readonly BytePacker bp;

		public readonly UnityAction<Dictionary<object, object>, KogamaDataType> callBack;

		public readonly bool readRuntimeData;

		public bool waitOneFrameBeforeDoneCallback;

		public float workTime;

		public bool WaitFrame => false;

		public AsyncBookkeeping(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData, UnityAction<int> doneCallback)
		{
		}

		public void Done()
		{
		}
	}

	private static AsyncBookkeeping asyncBookkeeping;

	private static readonly int serializeVersion;

	private const int maxDeserializeTimeBeforeService = 1000;

	private static int timeSinceService;

	public static bool SlowWorldCreation
	{
		set
		{
		}
	}

	public static int GetKoGaMaData(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
		return 0;
	}

	private static void GetPrototypeData(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack)
	{
	}

	private static int GetWorldObjectData(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
		return 0;
	}

	private static void GetLinks(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
	}

	private static void GetObjectLinks(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
	}

	public static void GetKoGaMaDataAsync(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData, UnityAction<int> doneCallback)
	{
	}

	private static bool GetPrototypeDataAsync()
	{
		return false;
	}

	private static bool GetWorldObjectDataAsync()
	{
		return false;
	}

	private static bool GetLinksAsync()
	{
		return false;
	}

	private static bool GetObjectLinksAsync()
	{
		return false;
	}

	private static void Execute()
	{
	}

	private static void DeserializePrototype(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack)
	{
	}

	private static int DeserializeWorldObject(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
		return 0;
	}

	private static void DeserializeLink(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
	}

	private static void DeserializeObjectLink(BytePacker bp, UnityAction<Dictionary<object, object>, KogamaDataType> callBack, bool readRuntimeData)
	{
	}

	private static void HandleService()
	{
	}
}
