using MV.Common;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AccessoryOffsetSlider : MonoBehaviour
{
	[SerializeField]
	private Slider slider;

	[SerializeField]
	private float defaultValue;

	private AccessorySlotType accessorySlot;

	private MVBody avatarBody;

	private bool isInPreview;

	public bool IsInPreview
	{
		set
		{
		}
	}

	public void Initialize(AccessorySlotType accessorySlot, int streamingAssetID)
	{
	}

	private void Initialize(MVBody avatarBody)
	{
	}

	public void ValueChanged()
	{
	}

	public void ChangeValue(float value)
	{
	}

	private void Reset()
	{
	}

	public void SyncPosition()
	{
	}
}
