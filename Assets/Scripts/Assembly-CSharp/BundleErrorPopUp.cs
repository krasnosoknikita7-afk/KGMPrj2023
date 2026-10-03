using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BundleErrorPopUp : MonoBehaviour
{
	[SerializeField]
	private Text header;

	[SerializeField]
	private Text buttonText;

	private UnityAction<bool> resultCallback;

	public void Initialize(UnityAction<bool> resultCallback, string header, string buttonText)
	{
	}

	public void OnButtonPressed()
	{
	}

	public void OnExit()
	{
	}
}
