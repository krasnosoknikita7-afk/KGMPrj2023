using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SoundViewItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private bool previewLoaded;

	private SoundTabInfo tabInfo;

	[SerializeField]
	private ToolTip toolTip;

	[SerializeField]
	private Image selectedImage;

	[SerializeField]
	private Image soundImage;

	[SerializeField]
	private Text title;

	[SerializeField]
	private GameObject loadingWheel;

	[SerializeField]
	private Button buttonComponent;

	private UnityAction<string> setNewOriginalUrl;

	private string originalUrl;

	private bool doneLoading;

	public void Initialize(SoundTabInfo info, string originalUrl, UnityAction<string> setNewOriginalUrl)
	{
	}

	private void OnDownloadFinished(UnityWebRequest www)
	{
	}

	public void UnsubscribePendingDownloads()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnClick()
	{
	}

	private void ChangeUrl(string url)
	{
	}

	private void OnDestroy()
	{
	}
}
