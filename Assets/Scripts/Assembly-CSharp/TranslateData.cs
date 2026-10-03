using UnityEngine;

public class TranslateData
{
	private readonly WorldObjectClientRef worldObjectClientRef;

	public Vector3 ungridifiedPosition;

	public Vector3 gridifiedPosition;

	public Vector3 prevGridifiedPosition;

	public Vector3 localDirCamToObject;

	public MVWorldObjectClient Wo => null;

	public TranslateData(MVWorldObjectClient wo, float gridSize)
	{
	}
}
