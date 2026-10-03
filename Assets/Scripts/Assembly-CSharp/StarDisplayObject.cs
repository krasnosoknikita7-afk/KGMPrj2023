using UnityEngine;

public class StarDisplayObject : MonoBehaviour
{
	[SerializeField]
	private TextMesh frontText;

	[SerializeField]
	private TextMesh backText;

	[SerializeField]
	private StreamedSharedMaterialHandler handler;

	private void Start()
	{
	}

	public void Destroy()
	{
	}

	public void SetAmount(int starAmount)
	{
	}

	public void SetScale(Vector3 size)
	{
	}
}
