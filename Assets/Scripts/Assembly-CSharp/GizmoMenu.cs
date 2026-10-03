using UGUI.Desktop.Scripts.EditMode.Gizmo;
using UnityEngine;

public class GizmoMenu : MonoBehaviour
{
	private Vector3 worldPosition;

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private GizmoButton rotate;

	[SerializeField]
	private GizmoButton xzTranslate;

	[SerializeField]
	private GizmoButton yTranslate;

	[SerializeField]
	private GizmoRotationModeButton xRotation;

	[SerializeField]
	private GizmoRotationModeButton yRotation;

	[SerializeField]
	private GizmoRotationModeButton zRotation;

	private RotationMode? rotationMode;

	private int woID;

	private EditorStateMachine editorStateMachine;

	public RotationMode RotationMode => RotationMode.X;

	public void Initialize(int id, Vector3 wp, EditorStateMachine esm)
	{
	}

	private void Update()
	{
	}

	private void Setup()
	{
	}

	private void SetToScreenPoint()
	{
	}

	private void HandleCloningHotkey()
	{
	}

	public void Pop()
	{
	}

	private void OnDestroy()
	{
	}

	private void PopWoDestroyed(object obj, WorldObjectDestroyedEventArgs args)
	{
	}

	private void Clone()
	{
	}

	private void CloneRoot()
	{
	}

	private bool CanClone()
	{
		return false;
	}

	private bool CanCloneRoot()
	{
		return false;
	}

	public void ChangeRotationModeToX()
	{
	}

	public void ChangeRotationModeToY()
	{
	}

	public void ChangeRotationModeToZ()
	{
	}

	private void ChangeRotationMode(RotationMode mode, GizmoRotationModeButton highlight)
	{
	}
}
