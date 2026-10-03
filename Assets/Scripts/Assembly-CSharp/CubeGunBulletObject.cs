using UnityEngine;

public class CubeGunBulletObject : MonoBehaviour
{
	[SerializeField]
	private Bullet bullet;

	[SerializeField]
	private CubeBullet cubeBullet;

	[SerializeField]
	private AudioSource audioSource;

	private byte materialID;

	public Bullet Bullet => null;

	public CubeBullet CubeBullet => null;

	public static CubeGunBulletObject Create(MVPickupOwner owner, Vector3 origin, byte materialID)
	{
		return null;
	}

	private void HandleCubeHitLocal(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	private void HandleCubeHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}
}
