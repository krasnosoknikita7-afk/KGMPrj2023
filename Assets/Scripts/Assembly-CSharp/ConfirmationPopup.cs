using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ConfirmationPopup : MonoBehaviour
{
	private UnityAction<bool, ConfirmationPopup> resultCallback;

	[SerializeField]
	private Text text;

	[SerializeField]
	private Text header;

	[SerializeField]
	private Button okButton;

	[SerializeField]
	private Button cancelButton;

	[SerializeField]
	public bool hideAll;

	public void Initialize(string text, UnityAction<bool, ConfirmationPopup> resultCallback, string header)
	{
	}

	public void Pop()
	{
	}

	private void Ok()
	{
	}

	private void Cancel()
	{
	}
}
