using UnityEngine;

namespace UGUI.Desktop.Scripts.EditMode.Gizmo
{
	public class GizmoRotationButtonHolderNg : MonoBehaviour
	{
		[SerializeField]
		private GizmoRotationButtonNg leftButton;

		[SerializeField]
		private GizmoRotationButtonNg rightButton;

		[SerializeField]
		private GizmoRotationButtonNg flipButton;

		public void Setup(bool canRotate, bool memberRequired)
		{
		}
	}
}
