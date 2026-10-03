using System;
using System.Runtime.CompilerServices;
using MV.WorldObject.SpawnRoles;
using UnityEngine;

public class SpawnRolesManager
{
	private readonly SpawnRolesRuntimeData spawnRolesRuntimeData;

	private readonly ISpawnRoleChangeHandler spawnRoleChangeHandler;

	[CompilerGenerated]
	private Action<int> m_OnSpawnRoleActivated;

	public int SpawnRoleId => 0;

	public event Action<int> OnSpawnRoleActivated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public SpawnRolesManager(ISpawnRoleChangeHandler spawnRoleChangeHandler, SpawnRolesRuntimeData spawnRolesRuntimeData)
	{
	}

	public void ActivateSpawnRole(int newSpawnRoleId, Vector3 position, Quaternion rotation)
	{
	}

	public void OnAvatarCreated(int id)
	{
	}

	public void AddSpawnRole(int id)
	{
	}
}
