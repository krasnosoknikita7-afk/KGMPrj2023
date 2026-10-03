using System;
using System.Collections.Generic;
using UnityEngine;

public class UseInteractorVisualization : MonoBehaviour
{
	private readonly List<UseRequirement> useRequirements;

	private Vector3 pivot;

	private const float BaseDist = 1.3f;

	private float dist;

	private float spacing;

	private float scale;

	private int active;

	private CullingSubscriberBase cullingSubscriberBase;

	private bool hasInputBlockingRequirement;

	private bool visible;

	private const float ScaleTime = 1f;

	private MVWorldObjectClient wo;

	public bool HasUseRequirements { get; private set; }

	public void Initialize(float yOffset, MVWorldObjectClient wo)
	{
	}

	private void SetupCulling()
	{
	}

	private void ChangeUseRequirements(Func<UseRequirement, bool> includeUseRequirementInUpdate, Func<UseRequirement, bool> updateRequirement)
	{
	}

	private static bool UseRequirementActive(UseRequirement useRequirement)
	{
		return false;
	}

	private static bool SetUseRequirementActive(UseRequirement useRequirement, bool b)
	{
		return false;
	}

	private void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void UpdatePosition(Vector3 pos)
	{
	}

	private void OnDestroy()
	{
	}

	private void RemoveCulling()
	{
	}

	private void CalculateSpacing()
	{
	}

	private void CalculateScale()
	{
	}

	private void Update()
	{
	}

	private void ChangeLOD(float distance)
	{
	}

	private static bool SetUseRequirementScale(UseRequirement useRequirement, Vector3 scale)
	{
		return false;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Disable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void UpdateData(Dictionary<object, object> data, int ownerID)
	{
	}

	private void CheckCullingSetup()
	{
	}

	public void AddUseRequirement(UseRequirement useRequirement)
	{
	}

	public UseGUIResult EvaluateUsability()
	{
		return (UseGUIResult)0;
	}

	public ShowUseOption GetShowOptions()
	{
		return ShowUseOption.Normal;
	}

	public void PayUseCost()
	{
	}

	public void DestroyRequirementObjects(Dictionary<object, object> data)
	{
	}
}
