using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UGUI.Desktop.Scripts.EditMode.Inventories;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchEditModeController : ModeControllerBase, IEditStateCommands, IEventSystemHandler, IEditModeUI, IGridSnapHandler, IEditModeController
{
	[CompilerGenerated]
	private sealed class _003CHandleCursorVisible_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CHandleCursorVisible_003Ed__55(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private bool enterPlayModeOnceGuard;

	private bool enterBuildModeOnceGuard;

	private bool isInPlayInEditMode;

	private Action<EditModeChangeArgs> editModeChange;

	private bool gridSnap;

	private TouchPlayModeController mobilePlayModeController;

	private PlayModeControlsBase playModeControlsBase;

	[SerializeField]
	private EditorWorldObjectCreation editorWorldObjectCreation;

	[SerializeField]
	private UIStack uiStack;

	[SerializeField]
	private GameObject stackBottom;

	[SerializeField]
	private ChatControllerUGUI chatController;

	[SerializeField]
	private DrawPlaneControllerUUI drawPlaneController;

	[SerializeField]
	private MaterialsControllerEditMode materialsController;

	[SerializeField]
	private ContextMenuController contextMenuController;

	[SerializeField]
	private GizmoController gizmoController;

	[SerializeField]
	private EditModeRepositoryController repositoryController;

	[SerializeField]
	private EditModeClientShopController clientShopController;

	[SerializeField]
	private PlayerInventoryController playerInventoryController;

	[SerializeField]
	private CreateCubeModelController createCubeModelController;

	[SerializeField]
	private RectTransform notificationsManager;

	[SerializeField]
	private ChatBubbleController chatBubbleController;

	[SerializeField]
	private CanvasScaler canvasScaler;

	[SerializeField]
	private EditMode3DController editMode3DControllerPrefab;

	[SerializeField]
	private FirstTimeSetupTerrainEditTutorial firstTimeSetupTerrainEditTutorial;

	[SerializeField]
	private SetupCubeModelTutorialUI setupCubeModelTutorialUI;

	[SerializeField]
	private GoldPurchasedTracker goldPurchasedTracker;

	private float focusTime;

	private bool focusSuppressInput;

	private const float focusTimeInputSupressTimeOut = 5f;

	public EditorStateMachine EditModeStateMachine { get; set; }

	public bool IsInPlayInEditMode => false;

	public PlayerShopInventoryRepository PlayerShopInventoryRepository { get; set; }

	public Action<EditModeChangeArgs> EditModeChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void HandleFocusInputSupress()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void ToggleHD()
	{
	}

	public void RegisterPlayModeController(TouchPlayModeController mobilePlayModeController)
	{
	}

	public override void Initialize()
	{
	}

	private void HideUI()
	{
	}

	public void DisableEditMode()
	{
	}

	public void EnterPlayMode()
	{
	}

	private void LeaveEditPlayMode()
	{
	}

	public void EnterBuildMode()
	{
	}

	public void SetState(EditorEvent editorEvent)
	{
	}

	public void ClearStateStack()
	{
	}

	[IteratorStateMachine(typeof(_003CHandleCursorVisible_003Ed__55))]
	private IEnumerator HandleCursorVisible()
	{
		return null;
	}

	public bool IsGridSnap()
	{
		return false;
	}

	public void Set(bool snap)
	{
	}

	private void RegisterShortcuts()
	{
	}

	public void Respawn()
	{
	}

	public void MoveToSelectedObject()
	{
	}

	public void DeleteWoid(int woid)
	{
	}

	public void SetUIReady()
	{
	}
}
