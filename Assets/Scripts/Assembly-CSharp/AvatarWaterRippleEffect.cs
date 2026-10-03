using UnityEngine;

public class AvatarWaterRippleEffect : WaterSplashComponent
{
	[Header("AirBubbles")]
	[SerializeField]
	private ParticleSystem airBubbleParticlesPrefab;

	[SerializeField]
	private Vector3 airBubbleOffset;

	[SerializeField]
	[Header("Dependencies")]
	private Avatar avatar;

	private ParticleSystem airBubbleParticles;

	private GameObject airBubbleCollitionPlane;

	private bool isInitialized;

	private float AvatarHeight => 0f;

	public override void Initialize(IMovable obj)
	{
	}

	protected override void Update()
	{
	}
}
