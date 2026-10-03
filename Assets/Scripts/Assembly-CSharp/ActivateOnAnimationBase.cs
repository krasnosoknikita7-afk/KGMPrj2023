using UnityEngine;

public abstract class ActivateOnAnimationBase : MonoBehaviour
{
	private MVAvatar mvAvatar;

	protected virtual void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private Avatar GetAvatar()
	{
		return null;
	}

	public abstract void OnAvatarAnimationChange(string newAnimation);
}
