using UnityEngine;

public class GameSetupOptions : MonoBehaviour
{
	[SerializeField]
	private ToggleButtonAnimation reviveToggleButton;

	private static bool isReviveEnabled;

	private static bool reviveUpdated;

	public static bool IsReviveEnabled => false;

	private void Start()
	{
	}

	public void ToggleRevive()
	{
	}
}
