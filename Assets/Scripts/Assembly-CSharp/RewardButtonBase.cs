using UnityEngine;
using UnityEngine.UI;

public class RewardButtonBase : MonoBehaviour
{
	[SerializeField]
	private Image RadialFill;

	protected virtual void EnableEffects()
	{
	}

	protected virtual void DisableEffects()
	{
	}

	protected virtual void UpdateOutline(float progress)
	{
	}
}
