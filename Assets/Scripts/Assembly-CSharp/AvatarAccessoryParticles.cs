using UnityEngine;

public class AvatarAccessoryParticles : AvatarAccessory
{
	private Vector3 prevPosition;

	private AccessoryParticlesSettings accessoryParticlesSettings;

	private ParticleSystem rootParticleSystem;

	public AccessoryParticlesSettings AccessoryParticlesSettings => null;

	public ParticleSystem RootParticleSystem => null;

	public override AccessorySettings AccessorySettings => null;

	public override Bounds GetWorldBounds()
	{
		return default;
	}

	public override Bounds GetLocalBounds()
	{
		return default;
	}

	protected override void Update()
	{
	}
}
