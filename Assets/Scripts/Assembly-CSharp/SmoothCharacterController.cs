using UnityEngine;

public class SmoothCharacterController : MonoBehaviour
{
	private MvCharacterController controller;

	private SmoothPhysicsMovement smoothPhysicsMovement;

	public MvCharacterController Controller => null;

	public void Init(GameObject worldObjectRoot, CullingSubscriberBase cullingSubscriberBase, MVWorldObjectClient worldObjectOwner)
	{
	}

	public void Reset()
	{
	}

	public void SmoothMove()
	{
	}

	private void OnDestroy()
	{
	}

	public SmoothCharacterController Clone(GameObject targetGameObject, GameObject seat, CullingSubscriberBase cullingSubscriberBase, MVWorldObjectClient worldObjectOwner)
	{
		return null;
	}
}
