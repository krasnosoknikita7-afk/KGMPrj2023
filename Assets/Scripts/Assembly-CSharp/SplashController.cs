using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SplashController : StreamedAudioClip.IReceiver
{
	private class ObjectData
	{
		public float TimeSinceLastRingEmission { get; set; }

		public Vector3 LastRingPosition { get; set; }

		public int LastFrameInWater { get; set; }

		public bool IsInWater { get; set; }
	}

	[SerializeField]
	[Header("Rings")]
	private ParticleSystem waterRingParticles;

	[SerializeField]
	private float timeBeforeNewRingIsEmitted;

	[SerializeField]
	private float distanceBeforeNewRingIsEmitted;

	[Header("Splash")]
	[SerializeField]
	private ParticleSystem waterSplashParticles;

	[SerializeField]
	[Tooltip("Actual number is based off avatar speed.")]
	private float baseNumberOfSplashParticles;

	[SerializeField]
	[Tooltip("Actual number is based off avatar speed.")]
	[Range(0f, 4f)]
	private float baseSplashParticlesSpeed;

	[SerializeField]
	private Color splashTint;

	[Header("Pillar")]
	[SerializeField]
	private ParticleSystem waterPillarParticles;

	[SerializeField]
	[Range(0f, 10f)]
	private float waterPillarDensity;

	[SerializeField]
	private Color pillarTint;

	[Header("Sound")]
	[Range(0f, 1f)]
	[SerializeField]
	private float splashSoundVolume;

	[SerializeField]
	private StreamedAudioClip streamedSplashSound;

	private AudioClip splashSound;

	private static int currentObjectID;

	private static readonly Dictionary<int, ObjectData> objectIDToData;

	public int NewObjectID => 0;

	public void Initialize()
	{
	}

	public void Destroy()
	{
	}

	public void CleanUpInactiveObjectIDs()
	{
	}

	public void WaterSplash(Bounds bounds, Vector3 velocity, int objectID)
	{
	}

	private float CalcSplashSoundVolume(Vector3 velocity)
	{
		return 0f;
	}

	private static ObjectData GetObjectData(int objectID)
	{
		return null;
	}

	private static Vector3 BoundsToPosition(Bounds b)
	{
		return default;
	}

	private void EmitWaterRing(Vector3 position)
	{
	}

	private void EmitWaterSplash(Vector3 position, Vector3 velocity)
	{
	}

	private void EmitWaterPillar(Vector3 position, Vector3 impactVelocity)
	{
	}

	public void OnAudioReceived(AudioClip a)
	{
	}
}
