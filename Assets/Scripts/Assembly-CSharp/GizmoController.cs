using UGUI.Desktop.Scripts.EditMode.Gizmo;
using UnityEngine;
using UnityEngine.EventSystems;

public class GizmoController : MonoBehaviour, IGizmoHandler, IEventSystemHandler
{
	private EditorStateMachine editorStateMachine;

	[SerializeField]
	private GizmoMenu gizmoMenuPrefab;

	[SerializeField]
	private GizmoMenuNg gizmoMenuNgPrefab;

	private GizmoMenu gizmoMenuInstance;

	private GizmoMenuNg gizmoMenuNgInstance;

	private RotationHelper rotationHelper;

	private bool ignoreSelectionOnce;

	public bool IgnoreSelectionOnce
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Initialize(EditorStateMachine esm)
	{
	}

	public void Show(int id, Vector3 worldPosition, EditorStateMachine e)
	{
	}

	private void OnGizmoMenuPop()
	{
	}

	public void Handle(GizmoAction action)
	{
	}

	void IGizmoHandler.IgnoreSelectionOnce()
	{
	}

	public void Hide()
	{
	}
}
