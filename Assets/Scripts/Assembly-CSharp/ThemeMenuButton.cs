using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThemeMenuButton : MonoBehaviour
{
	public interface IClickHandler : IEventSystemHandler
	{
		void OpenThemesMenu();
	}

	[SerializeField]
	private Button button;

	[SerializeField]
	private ToolTip toolTip;

	private static readonly string toolTipStr_ButtonDisabled;

	private static readonly string toolTipStr_ButtonEnabled;

	protected void Awake()
	{
	}

	private void SetButtonAvailability(MVLocalPlayer.PlanetOwnershipType planetOwnership)
	{
	}

	public void OnClick()
	{
	}
}
