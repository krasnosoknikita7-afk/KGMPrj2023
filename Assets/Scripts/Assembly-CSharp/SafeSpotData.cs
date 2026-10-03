using UnityEngine;

public struct SafeSpotData
{
	public Vector3 Position;

	public Quaternion Rotation;

	public Vector3 CameraPosition;

	public Quaternion CameraRotation;

	public SafeSpotData(Vector3 pos, Quaternion rot, Vector3 camPos, Quaternion camRot)
	{
		Position = default;
		Rotation = default;
		CameraPosition = default;
		CameraRotation = default;
	}
}
