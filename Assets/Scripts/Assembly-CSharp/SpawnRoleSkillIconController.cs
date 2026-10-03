using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleSkillIconController : MonoBehaviour
{
	[SerializeField]
	private Image skillIcon;

	[SerializeField]
	private Image negativeIcon;

	[SerializeField]
	private Image negativeBackgroundIcon;

	public void ChangeColor(Color newIconColor, Color newBackgroundColor)
	{
	}

	public void HandleNegativeState(int skillCost)
	{
	}

	public void ChangeSize(float width, float height)
	{
	}
}
