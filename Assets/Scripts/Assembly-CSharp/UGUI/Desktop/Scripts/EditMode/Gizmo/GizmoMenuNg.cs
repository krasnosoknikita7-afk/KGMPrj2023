using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI.Desktop.Scripts.EditMode.Gizmo
{
	public class GizmoMenuNg : MonoBehaviour
	{
		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private GizmoButton xzTranslate;

		[SerializeField]
		private GizmoButton yTranslate;

		[SerializeField]
		private Transform rotationMenu;

		[SerializeField]
		private Transform resetRotationButton;

		[SerializeField]
		private GizmoRotationButtonHolderNg xRotationHolder;

		[SerializeField]
		private GizmoRotationButtonHolderNg yRotationHolder;

		[SerializeField]
		private GizmoRotationButtonHolderNg zRotationHolder;

		[SerializeField]
		private bool useRotationTexts;

		[SerializeField]
		private Text xRotationText;

		[SerializeField]
		private Text yRotationText;

		[SerializeField]
		private Text zRotationText;

		[SerializeField]
		private GamePassesTextBubble memberToRotate;

		private readonly HashSet<GizmoAction> subscriberActions;

		private Vector3 worldPosition;

		private int woID;

		private EditorStateMachine editorStateMachine;

		private MVWorldObjectClient worldObjectClient;

		private bool isSubscriber;

		private bool objectLocked;

		private readonly HashSet<WorldObjectType> xyzLockedItems;

		public void Initialize(int id, Vector3 wp, EditorStateMachine esm)
		{
		}

		private void Update()
		{
		}

		private void Setup()
		{
		}

		private void OnSpawnRoleActivated(int obj)
		{
		}

		private void OnJoinChanged(MVJoinState obj)
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

		public void RotateStepLeftX()
		{
		}

		public void RotateStepRightX()
		{
		}

		public void RotateStepLeftY()
		{
		}

		public void RotateStepRightY()
		{
		}

		public void RotateStepLeftZ()
		{
		}

		public void RotateStepRightZ()
		{
		}

		public void FlipX()
		{
		}

		public void FlipY()
		{
		}

		public void FlipZ()
		{
		}

		private void DoGizmoAction(GizmoAction gizmoAction)
		{
		}

		public void ResetRotation()
		{
		}

		private void UpdateRotationText()
		{
		}
	}
}
