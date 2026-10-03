using Assets.Scripts.AdIntegration;
using UnityEngine;
using UnityEngine.Events;

public class MVGameControllerDesktop : MVGameControllerBase
{
	[SerializeField]
	private GameObject eventSystem;

	private IEditModeObjectPicker editModeObjectPicker;

	private bool applicationHasFocus;

	private ILockCursorManager lockCursorManager;

	private IAdManager adManager;

	private static MVGameControllerDesktop Instance => null;

	public static UnityAction OnApplicationLostFocus { get; set; }

	public static UnityAction OnApplicationRegainedFocus { get; set; }

	public static ILockCursorManager LockCursorManager => null;

	public static bool IsCursorLock => false;

	protected override IAdManager GetAdManager => null;

	protected override bool IsPlayingInternal => false;

	public static void CursorLock(bool val, bool withoutCallback = false)
	{
	}

	protected override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public static void RegisterPlayModeController(DesktopPlayModeController playModeController)
	{
	}

	public new static void UnregisterPlayModeController()
	{
	}

	public static void RegisterAvaterEditModeController(DesktopAvatarEditModeController avatarEditModeController)
	{
	}

	public static void RegisterEditModeController(DesktopEditModeController editModeController)
	{
	}

	public static void UnregisterEditModeController()
	{
	}

	protected override void UpdateInternal()
	{
	}

	protected void OnApplicationFocus(bool focus)
	{
	}

	protected override void HandleApplicationQuit(QuitBaseCallback quitBaseCallback)
	{
	}

	protected override void CleanUp()
	{
	}
}
