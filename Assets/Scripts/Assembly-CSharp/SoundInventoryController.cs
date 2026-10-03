using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SoundInventoryController : MonoBehaviour, IHandleSettingChanged, IEventSystemHandler
{
	private InventoryController inventoryController;

	private readonly Dictionary<int, TabState> tabs;

	private int selectedTab;

	private readonly Dictionary<int, List<SoundTabInfo>> soundTabInfos;

	[SerializeField]
	private InventoryController inventoryControllerPrefab;

	[SerializeField]
	private int numberOfSlotsPrPage;

	[SerializeField]
	private SoundViewItem soundViewItemPrefab;

	[SerializeField]
	private SettingsBase settingsBase;

	[SerializeField]
	private StreamedAudioClipList audioUrls;

	private List<StreamedAudioClipInfo> urls;

	private readonly Dictionary<int, int> categorysAmount;

	private string originalURL;

	private readonly Dictionary<string, int> categoryToNameCombinations;

	public void Initialize(int woID, GameObject root)
	{
	}

	private static void DebugPrintSound(Dictionary<object, object> data)
	{
	}

	public void UpdateContent()
	{
	}

	private void SetNewOriginalUrl(string url)
	{
	}

	private void PageTurned(int dir)
	{
	}

	private void TabSelected(int tab)
	{
	}

	public void OnSettingChanged(string key, object value)
	{
	}
}
