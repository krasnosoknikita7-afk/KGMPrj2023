using System.Collections.Generic;
using UnityEngine;

public class JetPackVisualization : VehicleVisualizationBase
{
	private Vector3 prevWorldPosition;

	private float smoothMoveSpeed;

	private float smoothPitchFactor;

	private float smoothRollFactor;

	private float pitchMax;

	private float pitchSpeedTime;

	private float pitchFactor;

	private float smoothMoveSpeedTime;

	private Vector3 posDiff;

	private float originalMaxEmission;

	private float originalMaxSize;

	public AudioSource moving;

	public VehicleBlinker vehicleBlinker;

	public Transform JetPackRoot;

	private float lastOverHeatNotificationTime;

	public List<ParticleSystem> thrusters;

	private MVJetPack.JetModeType mode;

	private bool modeChanged;

	public void Init(bool isInSpawner, Transform jetPackCubeModel, MVRuntimeDataVariable jetMode)
	{
	}

	public void OnJetModeChange(MVJetPack.JetModeType newMode)
	{
	}

	public void EnableThruster(bool enable)
	{
	}

	public void DoOverheatBlinking()
	{
	}

	public void ShowOverHeatWarning()
	{
	}

	private void Update()
	{
	}

	private void HandleJetMode()
	{
	}

	private void SetMaxSizeForThrusters(float maxSize, float maxEmission)
	{
	}

	private void UpdateSpartialValues()
	{
	}

	private void JetPackPitch()
	{
	}

	private void JetPackRoll()
	{
	}
}
