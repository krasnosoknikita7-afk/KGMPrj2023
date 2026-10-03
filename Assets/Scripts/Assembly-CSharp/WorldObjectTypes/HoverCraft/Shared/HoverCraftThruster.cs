using UnityEngine;

namespace WorldObjectTypes.HoverCraft.Shared
{
	public class HoverCraftThruster : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem thrusterParticleSystem;

		[SerializeField]
		private GameObject thrusterMesh;

		public void UpdateSize(float thrustersSize)
		{
		}

		public void UpdateColor(Gradient thrustersColor)
		{
		}

		public void ToggleOnOff(bool useThrusters)
		{
		}

		public void Disable()
		{
		}
	}
}
