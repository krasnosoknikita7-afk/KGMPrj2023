using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ShortcutHandler : MonoBehaviour
{
	[SerializeField]
	private KogamaControls kogamaControl;

	[SerializeField]
	private KeyState keyState;

	[SerializeField]
	private Button button;

	private void Start()
	{
	}

	private void Reset()
	{
	}

	private void Callback()
	{
	}

	private void OnDestroy()
	{
	}
}
