public class FirstTimeActivatableSetEventOnShow : FirstTimeActivatableElementBase
{
	private bool setFirstTimeEvent;

	public override bool CanShow => false;

	private void Update()
	{
	}

	public override void OnShow()
	{
	}
}
