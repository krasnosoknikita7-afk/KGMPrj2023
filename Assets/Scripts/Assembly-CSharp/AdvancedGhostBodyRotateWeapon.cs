using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class AdvancedGhostBodyRotateWeapon : MonoBehaviour
{
	private float damage;

	private float impulseStrength;

	private float factor;

	private TimeoutMap timeoutMap;

	private AudioSource weaponHitSound;

	public MVTeam alliedTeam;

	private List<AdvancedGhostTriggerBase> ghostTriggers;

	public MVTeam AlliedTeam
	{
		get
		{
			return MVTeam.Blue;
		}
		set
		{
		}
	}

	public void SetAttackValueFactor(float factor)
	{
	}

	public void Init(AudioSource weaponHitSound, MVCubeModelBase body)
	{
	}

	private void body_Changed(CubeModelChangedEventArgs e)
	{
	}

	private void SetupWeaponCollision()
	{
	}

	private void Update()
	{
	}

	private void Attack(int woid)
	{
	}
}
