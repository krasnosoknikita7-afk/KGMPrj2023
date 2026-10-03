using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.EditablePickupItem
{
	public class MVEditablePickupItemBaseObject : MVPickupItemBaseObject
	{
		[SerializeField]
		private Transform cubeModelParent;

		public Transform CubeModelParent => null;
	}
}
