using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ModeControllerBase : MonoBehaviour, IToggleFps, IEventSystemHandler, IPlayModeUI
{
	[SerializeField]
	private GameObject fpsCounterPrefab;

	private GameObject fpsCounter;

	public virtual bool InLobbyState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDying { get; set; }

	public virtual void Initialize()
	{
	}

	public virtual void ShowEUseIcon(ShowUseOption option, int woId = 0)
	{
	}

	public virtual void HideEUseIcon()
	{
	}

	public virtual IGUICrossHair GetCrossHair()
	{
		return null;
	}

	protected bool CannotLeaveEditPlayMode()
	{
		return false;
	}

	public void ToggleFps()
	{
	}

	protected void HandleFpsShortcut()
	{
	}
}
