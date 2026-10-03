using UnityEngine;

namespace WorldObjectTypes.Avatar.Shared
{
	public class AvatarPaused : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem particleSystem;

		private int ownerActorNr;

		private bool delayedPlay;

		public void Init(int ownerActorNr)
		{
		}

		private void OnPause()
		{
		}

		private void OnResume()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}
