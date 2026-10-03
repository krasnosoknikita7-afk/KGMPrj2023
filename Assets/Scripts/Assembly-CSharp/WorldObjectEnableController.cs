using UnityEngine;

public class WorldObjectEnableController : MonoBehaviour
{
	private EnableState enableState;

	[SerializeField]
	private GreyOutObjectScript greyOutObjectScript;

	public EnableState EnableState
	{
		get
		{
			return EnableState.DisableAndHide;
		}
		set
		{
		}
	}
}
