using UnityEngine;

public class MeleeWeaponAnimationEventHandler : MonoBehaviour
{
	public PickupItemMeleeWeapon meleeWeaponItem;

	public Transform target;

	public TrailArc trailArcPrefab;

	private TrailArc arcInstance;

	public void MeleeWeaponArcEnd()
	{
	}

	private void MeleeWeaponArcStart()
	{
	}

	private void OnDisable()
	{
	}
}
