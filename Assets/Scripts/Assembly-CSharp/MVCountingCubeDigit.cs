using UnityEngine;

public class MVCountingCubeDigit : MonoBehaviour
{
	public Material CountingCubeDigitMaterial;

	private MeshRenderer meshRenderer;

	private int _number;

	public int Number
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MeshRenderer MeshRenderer => null;

	private void Awake()
	{
	}

	private void SetMaterialOffset()
	{
	}
}
