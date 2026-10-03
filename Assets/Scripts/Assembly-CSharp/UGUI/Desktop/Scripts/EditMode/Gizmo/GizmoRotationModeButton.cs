using Gamestrap;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI.Desktop.Scripts.EditMode.Gizmo
{
	public class GizmoRotationModeButton : MonoBehaviour
	{
		[SerializeField]
		private Text text;

		private Color originalTextColor;

		private readonly Color selectedTextColor;

		private Button button;

		private GradientEffect gradient;

		private ColorBlock originalColorBlock;

		private ColorBlock selectedColorBlock;

		private void Awake()
		{
		}

		public void ResetColors()
		{
		}

		public void Highlight()
		{
		}
	}
}
