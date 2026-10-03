using UnityEngine;

public class InGameControls : MonoBehaviour
{
	[SerializeField]
	private TouchButtonsBase inGameButtonsPrefab;

	[SerializeField]
	private GameObject avatarJoystickPrefab;

	[HideInInspector]
	public TouchButtonsBase InGameButtons;

	private void Awake()
	{
	}
}
