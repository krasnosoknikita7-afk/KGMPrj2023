using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class AdvancedGhostIcon : MonoBehaviour
{
	[SerializeField]
	private GhostBody ghostBody;

	[SerializeField]
	private List<OculusTeamGameObject> teamIrisObjects;

	private bool visible;

	private bool wantsVisible;

	private const float advancedGhostBodyMaxRadius = 4f;

	private const int ghostIconDistanceBand = 3;

	private CullingSubscriberBase cullingSubscriberBase;

	private LineRangeIndicator lineRangeIndicator;

	public float Radius
	{
		set
		{
		}
	}

	public MVTeam Team
	{
		set
		{
		}
	}

	public void Init(MVAdvancedGhost advancedGhost, MVCubeModelBase body, bool enabledCulling, MVTeam team)
	{
	}

	public void SetGameMode(bool isPlayMode)
	{
	}

	private void SetVisibility()
	{
	}

	private void SetupCulling(MVAdvancedGhost advancedGhost)
	{
	}

	private void AdvancedGhostOnPositionChanged(object sender, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnStateChange(CullingGroupEvent cullingGroupEvent)
	{
	}

	private void CloneCubeMeshes(MVCubeModelBase body)
	{
	}

	private void body_Changed(CubeModelChangedEventArgs e)
	{
	}

	private void AddSphereVolumeIndicator(int Id)
	{
	}
}
