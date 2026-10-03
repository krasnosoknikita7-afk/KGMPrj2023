using UnityEngine;
using UnityEngine.UI;

public class CubeModelPopup : MonoBehaviour
{
	[SerializeField]
	private CubeModelPopupAction cubeModelPopupAction;

	[SerializeField]
	private RawImage scale25Percent;

	[SerializeField]
	private RawImage scale50Percent;

	[SerializeField]
	private RawImage scale100Percent;

	private byte materialID;

	private int woID;

	public void Initialize(byte currentMaterialId, int worldId = -1)
	{
	}

	public void OnModelScalePressed(float scale)
	{
	}
}
