using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class BackButtonHandler : MonoBehaviour
{
	[SerializeField]
	private Button invokeButton;

	[SerializeField]
	private KogamaControls kogamaControl;

	[SerializeField]
	private KeyState onKeyState;

	private void OnEnable()
	{
	}

	private void InvokeButton()
	{
	}

	private void OnDisable()
	{
	}
}
