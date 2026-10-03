using UnityEngine;

public class SkipConfirmation : MonoBehaviour
{
	[SerializeField]
	private PopElement popElement;

	[SerializeField]
	private ConfirmationPopup popup;

	public void CreateConfirmationPopup()
	{
	}

	private void HandleResult(bool confirmed, ConfirmationPopup popup)
	{
	}
}
