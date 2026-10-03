using UnityEngine;

namespace IngameController.MVEditor
{
	public class TransformGizmo : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer lineRendererX;

		[SerializeField]
		private LineRenderer lineRendererY;

		[SerializeField]
		private LineRenderer lineRendererZ;

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}
	}
}
