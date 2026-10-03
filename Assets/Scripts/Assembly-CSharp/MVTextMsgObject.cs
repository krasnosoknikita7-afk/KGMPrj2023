using UnityEngine;

public class MVTextMsgObject : ObjectPrefab
{
	[SerializeField]
	private TextMesh textMesh;

	[SerializeField]
	private Renderer textMeshRenderer;

	[SerializeField]
	private GameObject visualObject;

	private LookAtMainCamera billboardScript;

	public GameObject VisualObject => null;

	public TextMesh TextMesh => null;

	public Renderer TextMeshRenderer => null;

	public void Billboard(bool billboard)
	{
	}
}
