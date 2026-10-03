using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;
using MV.WorldObject;
using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.MeleeWeapon
{
	public static class MeleeWeaponData
	{
		public abstract class Keys : EditablePickupItemData.Keys
		{
			public const string TrailColor = "TrailColor";

			public const string HitEffectColor = "HitEffectColor";
		}

		private static readonly Dictionary<object, object> defaultItemValues;

		private static readonly Dictionary<object, object> minValues;

		private static readonly Dictionary<object, object> maxValues;

		public static readonly string[] fireSoundEffects;

		public static readonly string[] hitSoundEffects;

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

		public static bool IsLegacySword(int itemId)
		{
			return false;
		}
	}
}
