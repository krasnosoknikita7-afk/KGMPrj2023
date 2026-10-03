using UnityEngine;
using UnityEngine.UI;

public class DesktopCubeModelingToolsController : MonoBehaviour
{
	private CubeModelingStateMachine cubeModelingStateMachine;

	[SerializeField]
	private Button defaultTool;

	[SerializeField]
	protected Button editCube;

	[SerializeField]
	protected Button deletecube;

	[SerializeField]
	protected Button paintCube;

	[SerializeField]
	private float disabledAlpha;

	[SerializeField]
	private float enabledAlpha;

	public CubeModelingEvent ActiveTool { get; private set; }

	private void Awake()
	{
	}

	public CubeModelingStateMachine.HoverType CurrentlyHovered()
	{
		return CubeModelingStateMachine.HoverType.Corner;
	}

	public virtual void SetupButtons()
	{
	}

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
	{
	}

	private void Start()
	{
	}

	protected void SetToolActive(CubeModelingEvent cubeTool)
	{
	}

	private void SetButtonTransparency(CubeModelingEvent cubeTool)
	{
	}

	public void Select(CubeModelingEvent tool)
	{
	}

	public void SetAllToTransparent()
	{
	}

	private void SetAlpha(Image image, float alpha)
	{
	}
}
