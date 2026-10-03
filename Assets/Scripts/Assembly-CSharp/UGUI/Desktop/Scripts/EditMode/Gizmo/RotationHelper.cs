using System.Collections.Generic;
using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.Gizmo
{
	public class RotationHelper
	{
		private readonly EditorStateMachine editorStateMachine;

		public RotationHelper(EditorStateMachine editorStateMachine)
		{
		}

		public void ResetRotation()
		{
		}

		public void RotateStep(RotationMode rotationMode, float rotationSpeed)
		{
		}

		private bool IsRotationInvalid()
		{
			return false;
		}

		private static Vector3 GetPivot(List<WorldObjectClientRef> targets, List<Transform> targetTransforms)
		{
			return default;
		}

		public static void DoGridSnapping(List<WorldObjectClientRef> targets)
		{
		}

		public static bool ValidateTargets(List<WorldObjectClientRef> targets)
		{
			return false;
		}
	}
}
