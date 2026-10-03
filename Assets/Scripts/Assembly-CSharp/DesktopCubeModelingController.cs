using IngameController.CubeModeling;
using UnityEngine;
using UnityEngine.UI;

public class DesktopCubeModelingController : MonoBehaviour
{
	[SerializeField]
	private RawImage materialsButtonImage;

	[SerializeField]
	private DesktopCubeModelingToolsController desktopCubeModelingController;

	[SerializeField]
	private DesktopCubeModelingTogglesController togglesController;

	[SerializeField]
	private Sprite errorSprite;

	[SerializeField]
	private UploadGameScreenshotHandler screenshotHandler;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
	{
	}

	public void SetMaterial(byte materialId)
	{
	}

	public void PublishGame()
	{
	}

	public void PublishCallback(bool confirmed, ConfirmationPopup popup)
	{
	}

	private void OnPublishPlanetFinished(string completionMessage)
	{
	}

	public void TakeScreenshot()
	{
	}
}
