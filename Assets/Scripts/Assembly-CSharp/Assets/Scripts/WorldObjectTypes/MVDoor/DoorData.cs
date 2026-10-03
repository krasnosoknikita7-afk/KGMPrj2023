using System.Collections.Generic;
using Assets.Scripts.Tools;
using MV.WorldObject;
using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.MVDoor
{
	public static class DoorData
	{
		public static class Keys
		{
			public static string Name;

			public static string BeginOpen;

			public static string PlayersCanOpen;

			public static string ReverseOpenDirection;

			public static string OpenValue;

			public static string CloseValue;

			public static string ToggleTime;

			public static string DoorType;

			public static string DocType;

			public static string IsOpen;
		}

		public static Dictionary<DoorType, Dictionary<object, object>> defaultValues;

		public static object DefaultValue(DoorType doorType, string key)
		{
			return null;
		}

		public static Dictionary<object, object> DefaultData(DoorType doorType)
		{
			return null;
		}

		public static (IntVector, IntVector) GetEditPoints(DoorType doorType)
		{
			return default;
		}

		public static Enums.Vector3Axis GetDoorAxis(DoorType doorType)
		{
			return Enums.Vector3Axis.X;
		}

		public static Vector3 GetCubeModelLocalPosition(DoorType doorType, Transform animationRoot)
		{
			return default;
		}

		public static bool IsSliding(DoorType doorType)
		{
			return false;
		}
	}
}
