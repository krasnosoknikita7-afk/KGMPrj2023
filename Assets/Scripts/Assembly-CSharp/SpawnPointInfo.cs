using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPointInfo : MonoBehaviour, IGamePassShopContent
{
	[SerializeField]
	private Image TeamRequirementImage;

	public void Initialize(MVTeam teamRequirement)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}
}
