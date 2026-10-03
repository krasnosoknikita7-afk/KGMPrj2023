using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class BodyData : MonoBehaviour
{
	public enum PartIndex
	{
		Head = 0,
		Torso = 1,
		RArm = 2,
		LArm = 3,
		RUpLeg = 4,
		RLowLeg = 5,
		LUpLeg = 6,
		LLowLeg = 7,
		Holster = 8,
		Size = 9
	}

	public string[] PartNames;

	public Transform[] PartBones;

	[SerializeField]
	private Vector3[] PartBoneSpacePosition;

	private ObscuredFloat[][] PartConstraintsBoxMin;

	private ObscuredFloat[][] PartConstraintsBoxMax;

	private ObscuredInt[] PartConstraintsMinCubes;

	private Dictionary<string, int> partMap;

	private void InitVariables()
	{
	}

	private void Awake()
	{
	}

	public int GetPartIndex(string part)
	{
		return 0;
	}

	public Transform GetPartBone(PartIndex part)
	{
		return null;
	}

	public Transform GetPartBone(string part)
	{
		return null;
	}

	public Vector3 GetPartBoneSpacePosition(string part)
	{
		return default;
	}

	public Vector3 GetPartConstraintMin(string part)
	{
		return default;
	}

	public Vector3 GetPartConstraintMax(string part)
	{
		return default;
	}

	public Vector3 GetPartConstraintCenter(string part)
	{
		return default;
	}

	public int GetPartConstraintMinCount(string part)
	{
		return 0;
	}

	private static Vector3 GetVectorFromObscuredFloatArray(ObscuredFloat[] values)
	{
		return default;
	}
}
