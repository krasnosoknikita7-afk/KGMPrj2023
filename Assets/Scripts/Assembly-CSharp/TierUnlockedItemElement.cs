using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class TierUnlockedItemElement : MonoBehaviour
{
	[SerializeField]
	private InventoryItemPreviewer objectPreviewerPrefab;

	[SerializeField]
	private RawImage previewImage;

	[SerializeField]
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	[SerializeField]
	private Text itemAmountText;

	[SerializeField]
	private Image teamRequirementImage;

	private InventoryItemPreviewer objectPreviewer;

	private Transform rootTransform;

	private MVWorldObjectClient previewObject;

	private Vector3 cameraOffset;

	private MVTeam team;

	public void SetTeam(MVTeam team)
	{
	}

	public void Initialize(List<MVWorldObjectClient> tierShopItemData, int itemIndex)
	{
	}

	private GameObject CreatePreviewObjectClone()
	{
		return null;
	}

	private Color GetTeamColor(MVTeam team)
	{
		return default;
	}

	private void OnDestroy()
	{
	}
}
