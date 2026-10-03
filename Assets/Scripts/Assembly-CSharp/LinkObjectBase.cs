using UnityEngine;

public class LinkObjectBase : MonoBehaviour
{
	public int linkID;

	public bool isObjectLink;

	protected Vector3 startPos;

	protected Vector3 endPos;

	protected bool UpdatePositions(Vector3 newStartPos, Vector3 newEndPos)
	{
		return false;
	}
}
