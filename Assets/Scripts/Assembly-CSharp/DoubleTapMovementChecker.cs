public class DoubleTapMovementChecker
{
	private const float doubleTapThreshold = 0.3f;

	private KogamaControls[] movementControls;

	private KogamaControls lastMovement;

	private float timer;

	private bool doubleTap;

	public bool DoubleTap => false;

	public void FrameUpdate()
	{
	}
}
