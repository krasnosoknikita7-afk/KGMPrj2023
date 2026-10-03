using System.Collections.Generic;
using UnityEngine;

public class BlinkerBase : MonoBehaviour
{
	[SerializeField]
	protected Material blinkMaterial;

	protected int layerMask;

	protected bool visible;

	protected MeshFilter[] meshFilters;

	protected Dictionary<BlinkType, Blinker> blinkers;

	protected Camera targetCamera;

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MeshFilter[] MeshFilters
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void StartBlinking(BlinkType type, float duration = float.PositiveInfinity)
	{
	}

	public void StopBlinking(BlinkType type)
	{
	}

	public virtual void LateUpdate()
	{
	}

	protected void DoBlinking()
	{
	}

	protected virtual void BeforeDraw()
	{
	}

	private void OnDestroy()
	{
	}
}
