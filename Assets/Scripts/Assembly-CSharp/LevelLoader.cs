using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
	private const string SceneDesktopPlayMode = "DesktopPlayModeGUI";

	private const string SceneTouchPlayMode = "AndroidPlayModeGUI";

	private const string SceneTouchEditMode = "AndroidEditModeGUI";

	private const string SceneDesktopEditMode = "DesktopEditModeGUI";

	private const string SceneDesktopAvatarEditMode = "DesktopAvatarEditModeGUI";

	private static Dictionary<ScenesForMode, string[]> scenesForModeMap;

	private readonly List<AsyncOperation> pendingScenes;

	private Action callback;

	public void LoadScenes(MVGameMode gameMode, bool tourist, bool useTouch, Action callback)
	{
	}

	private void LoadScenes(ScenesForMode mode, Action callbackAction)
	{
	}

	private void Update()
	{
	}
}
