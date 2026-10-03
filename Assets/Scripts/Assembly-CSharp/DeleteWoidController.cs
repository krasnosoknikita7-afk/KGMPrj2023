using UnityEngine;

public class DeleteWoidController : MonoBehaviour
{
	[SerializeField]
	private PickHelper pickHelperPrefab;

	private int woid;

	public void Initialize()
	{
	}

	private void OnPick(MVWorldObjectClient wo, MVWorldObjectClient woParent)
	{
	}

	private void DeleteWorldObject(bool success, ConfirmationPopup popup)
	{
	}
}
