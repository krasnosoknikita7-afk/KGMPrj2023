using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator;
using UnityEngine;

public class SpawnRoleChangeHandlerLocal : ISpawnRoleChangeHandler
{
	private readonly SpawnRoleDataMediator SpawnRoleDataMediator;

	public SpawnRoleChangeHandlerLocal(SpawnRoleDataMediator spawnRoleDataMediator)
	{
	}

	public void ActivateSpawnRole(int prevSpawnRoleId, int newSpawnRoleId, Vector3 position, Quaternion rotation)
	{
	}
}
