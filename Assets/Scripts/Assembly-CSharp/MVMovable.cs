using System.Collections.Generic;
using UnityEngine;

public class MVMovable : MVBlueprintBase
{
	private static float direction;

	private List<MVMovable> MoveableChildren;

	private Vector3 localPos;

	private float timeToEnd;

	private float linearTime;

	private float fraction;

	private MovableVisualization movableVisualization;

	private float distance;

	private Quaternion orgRotation;

	private Vector3 velocity;

	private Vector3 angularDirection;

	private float angularSpeed;

	private int parentMoverID;

	private bool pausedMovement;

	private bool isVisible;

	private MVMovable parentMover;

	public MVCubeModelInstance CubeModel { get; private set; }

	public int CubeModelID => 0;

	public float Distance => 0f;

	public Quaternion OrgRotation => default;

	public Vector3 Velocity => default;

	public Vector3 AngularVelocity => default;

	public Vector3 AngularDirection => default;

	public float AngularSpeed => 0f;

	public int ParentMoverID => 0;

	public bool PausedMovement
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual Vector3 WorldVelocity => default;

	public MVMovable ParentMover => null;

	public bool IsRoot => false;

	public MVMovable RootMover => null;

	public override bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MVMovable(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	protected void SetVisible(bool newVisible)
	{
	}

	public override void OnInputStateChanged()
	{
	}

	public override void InitializeInventory()
	{
	}

	private void InitializeCommon()
	{
	}

	private string GetParamPath(string param)
	{
		return null;
	}

	public void SetDistance(float distance, bool updateWOData = false, bool syncServer = false)
	{
	}

	public void SetOrgRotation(Quaternion orgRotation, bool updateWOData = false, bool syncServer = false)
	{
	}

	public void SetVelocity(Vector3 velocity, bool updateWOData = false, bool syncServer = false)
	{
	}

	public void SetAngularDirection(Vector3 angularDirection, bool updateWOData = false, bool syncServer = false)
	{
	}

	public void SetAngularSpeed(float angularSpeed, bool updateWOData = false, bool syncServer = false)
	{
	}

	public void SetParentMoverID(int parentMoverID, bool updateWOData = false, bool syncServer = false)
	{
	}

	public void SyncProperties()
	{
	}

	private void ReadWOData()
	{
	}

	public void UpdateMoverTree(float directionFactor)
	{
	}

	public void UpdateMoverSubTree(float directionFactor, int breakid)
	{
	}

	public void AddMovableChild(MVMovable child)
	{
	}

	public void RemoveMovableChild(MVMovable child)
	{
	}

	private void Move(float directionFactor, int breakid)
	{
	}

	private void RecalcTimeToEnd()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Destroy()
	{
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}
}
