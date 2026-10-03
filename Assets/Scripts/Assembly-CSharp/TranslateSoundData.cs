using UnityEngine;

public struct TranslateSoundData
{
	public float moveValue;

	public bool moveToGridPos;

	public Vector3 worldPos;

	public TranslateSoundData(float moveValue, bool moveToGridPos, Vector3 worldPos)
	{
		this.moveValue = 0f;
		this.moveToGridPos = false;
		this.worldPos = default;
	}
}
