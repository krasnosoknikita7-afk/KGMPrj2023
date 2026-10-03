using MV.WorldObject.Accessories;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryTimeLimitDisplayer : MonoBehaviour
{
	[SerializeField]
	private Text timeLeftText;

	private AccessoryTimelimit accessoryTimeLimitData;

	private static readonly string format;

	public void Initialize(AccessoryTimelimit accessoryData)
	{
	}

	private void Update()
	{
	}
}
