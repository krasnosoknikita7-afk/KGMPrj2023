using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RespawnSettings : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private SettingsSlider respawnTimeSlider;

	[SerializeField]
	private SettingsInputFieldSlider respawnTimeInputField;

	[SerializeField]
	private GameObject respawnTimeSettingsUI;

	[SerializeField]
	private GameObject respawnActiveCheckmark;

	[SerializeField]
	private Toggle activeToggle;

	private int woID;

	private bool isInitialized;

	private bool isRespawnActive;

	private const string respawnString = "respawnTime";

	private const int respawnMaxTime = 1800;

	private const int respawnMinTime = 30;

	public void Initialize(int woID, GameObject root)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}

	public void HandleActiveToggle()
	{
	}

	private void AddRespawnTime()
	{
	}

	private void RemoveRespawnTime()
	{
	}

	private void SetRespawnUIVisibility(bool isRespawnActive)
	{
	}
}
