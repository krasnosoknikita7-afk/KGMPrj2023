using System.Collections.Generic;
using UnityEngine;

internal class ESTranslate : ESStateBase
{
	public const string TranslateModeType = "translateMode";

	public const string MoveWithAvatar = "moveWithAvatar";

	private float gridSize;

	private float stickyModifier;

	private float completelyStuckLimit;

	private bool recalcLocalDirCamToObjects;

	private List<TranslateData> translateDatas;

	private List<MVWorldObjectClient> targets;

	private const float _mouseSensitivity = 0.005f;

	private float initialDistance;

	private Vector3 originPrevFrame;

	private bool playTranslateSounds;

	private float scrollMoveDistance;

	private TranslateMode translateMode;

	private HashSet<int> woIds;

	private bool fixedToYPlane;

	private bool moveWithAvatar;

	private bool enteredStateWithPointerSelectReleased;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private bool IsValid()
	{
		return false;
	}

	private void UpdateLaserPosition(List<MVWorldObjectClient> wos)
	{
	}

	public override void Exit(EditorStateMachine e)
	{
	}

	private bool GetInitialAvatarMoveObjectHitDistance(EditorStateMachine e, ref float hitDistance)
	{
		return false;
	}

	private float GetInitialAvatarMoveObjectDistance(EditorStateMachine e)
	{
		return 0f;
	}

	private void RotateWithCamera(EditorStateMachine e, int targetIndex)
	{
	}

	private Vector3 GetDeltaMouse(EditorStateMachine e)
	{
		return default;
	}
}
