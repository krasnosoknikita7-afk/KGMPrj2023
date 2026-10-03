using Assets.Scripts.WorldObjectTypes.MVDoor;
using UnityEngine;

namespace WorldObjectTypes.MVDoor
{
	public class MVDoorObject : ObjectPrefab
	{
		[HideInInspector]
		public MVDoor doorLogic;

		[Header("Door Object Management")]
		public GameObject useInteractionRotator;

		public Transform animationRoot;

		public Collider useCollider;

		public Transform cube;

		[SerializeField]
		private TriggerBoxEvents triggerBoxEvents;

		[Header("Door Audio")]
		[SerializeField]
		private AudioSource audioSource;

		[SerializeField]
		private AudioClip doorOpenSound;

		[SerializeField]
		private AudioClip slidingDoorOpenSound;

		[SerializeField]
		private AudioClip trapDoorOpenSound;

		public TriggerBoxEvents TriggerBoxEvents => null;

		public float GetCurrentValue(DoorType doorType)
		{
			return 0f;
		}

		public void SetCurrentValue(float value, DoorType doorType)
		{
		}

		public void playOpenDoorSound(DoorType doorType)
		{
		}

		protected override void OnValidate()
		{
		}
	}
}
