using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.Costume
{
	public static class CostumeData
	{
		public abstract class Keys
		{
			public const string CubeModelId = "CubeModelId";

			public const string Name = "Name";

			public const string Health = "Health";

			public const string MovementSpeed = "MovementSpeed";

			public const string PlayerInvisible = "PlayerInvisible";

			public const string PlayersCanCollide = "PlayersCanCollide";

			public const string TrailEnabled = "TrailEnabled";

			public const string TrailLength = "TrailLength";

			public const string TrailColor = "TrailColor";
		}

		private static readonly Dictionary<object, object> defaultItemValues;

		private static readonly Dictionary<object, object> minValues;

		private static readonly Dictionary<object, object> maxValues;

		public static Dictionary<object, object> DefaultData()
		{
			return null;
		}

		public static Dictionary<object, object> DefaultItemData()
		{
			return null;
		}

		public static object DefaultValue(string key)
		{
			return null;
		}

		public static Color DefaultColor(string colorKey)
		{
			return default;
		}

		public static float MinValue(string key)
		{
			return 0f;
		}

		public static float MaxValue(string key)
		{
			return 0f;
		}

		public static (float, float) MinMaxValue(string key)
		{
			return default;
		}

		public static (IntVector, IntVector) GetEditPoints()
		{
			return default;
		}
	}
}
