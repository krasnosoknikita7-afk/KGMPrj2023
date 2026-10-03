using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class TierUnlockAccessItemsPopup : MonoBehaviour
{
	private struct AccessItemData
	{
		public MVWorldObjectDocumentationType type;

		public List<MVWorldObjectClient> worldObjects;

		public MVTeam teamRequirement;
	}

	[SerializeField]
	private Transform itemElementContainer;

	[SerializeField]
	private TierUnlockedItemElement tierUnlockedItemElementPrefab;

	public const string teamKey = "team";

	public void Initialize(GamePassTier tier, Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
	}

	private List<AccessItemData> GetSortedData(Dictionary<MVWorldObjectDocumentationType, List<MVWorldObjectClient>> tierShopData)
	{
		return null;
	}

	private bool HasAccessItemDataTeamAndObjectType(MVTeam teamRequirement, MVWorldObjectDocumentationType objectType, List<AccessItemData> accessItemsData)
	{
		return false;
	}

	private AccessItemData CreateAccessItemData(MVTeam teamRequirement, MVWorldObjectDocumentationType objectType)
	{
		return default;
	}
}
