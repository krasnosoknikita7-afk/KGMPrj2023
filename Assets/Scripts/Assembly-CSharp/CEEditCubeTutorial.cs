using System.Collections.Generic;
using MV.WorldObject;
using MV.WorldObject.MetaData;
using UnityEngine;

public class CEEditCubeTutorial : ESStateBase
{
	private class ResettingBookkeeping
	{
		private int resettingBeginTime;

		public int resettingDelay;

		private bool doReset;

		public bool isResetting;

		public bool DoReset => false;

		public bool ReadyToReset => false;

		public void InitializeResetting(int resettingDelay)
		{
		}

		public void StartResetting()
		{
		}
	}

	private int targetCubeModelId;

	private bool exiting;

	private IModelingConstraint constraint;

	private ConstraintVisualizer constraintVisualizer;

	private EditableCubeModelWrapper cubeModelWrapper;

	private static HashSet<FirstTimeEvent> successEvents;

	private static HashSet<FirstTimeEvent> disableCubeModelingEvents;

	private static HashSet<FirstTimeEvent> enableCubeModelingEvents;

	private float oneCubeDistance;

	private float multiCubeDistance;

	private Vector3 focusOffset;

	private FirstTimeCubeModelBlinker blinker;

	private bool hasExited;

	private IntVector zeroPos;

	private Dictionary<EditCubeChange, bool> firstTimeEventChangeCheck;

	private bool bordersExpanded;

	private MVCubeModelInstance selectedInstance;

	private CubeModelingStateMachine CMSM;

	private int mainCameraDefaultMask;

	private ResettingBookkeeping resettingBookkeeping;

	private bool disableCubeModeling;

	private bool enableCubemodeling;

	private MVCubeModelBase TargetCubeModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine e)
	{
	}

	private void HandleCubeModelingEnabling(FirstTimeEvent firstTimeEvent)
	{
	}

	public override void Exit(EditorStateMachine esm)
	{
	}

	private void SetFocus(float distance)
	{
	}

	private void SetupBlinker()
	{
	}

	private void CreateConstraint()
	{
	}

	private void OnClosed()
	{
	}

	private void OnEditCubeChange(int cubeCount, EditCubeChange editCubeChange)
	{
	}

	private Dictionary<EditCubeChange, bool> GetFirstTimeEventCheck()
	{
		return null;
	}

	private void SetFirstTimeEventsHappened(FirstTimeState firstTimeState, FirstTimeEvent firstTimeEvent)
	{
	}

	private bool DoReset()
	{
		return false;
	}
}
