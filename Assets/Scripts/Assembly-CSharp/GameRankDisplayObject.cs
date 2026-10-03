using MV.Common;
using UnityEngine;

public class GameRankDisplayObject : MonoBehaviour
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

	public void SetAmount(GamePassTier requiredRank)
	{
	}

	public void SetScale(Vector3 size)
	{
	}
}
