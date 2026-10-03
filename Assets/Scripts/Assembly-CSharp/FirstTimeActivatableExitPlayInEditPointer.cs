using UnityEngine;

public class FirstTimeActivatableExitPlayInEditPointer : FirstTimeActivatableButtonPointer
{
	[SerializeField]
	private GameObject leavePlayInEdit;

	private float timeBeforeActive;

	private float currentTime;

	private bool canShow;

	private bool isDeleting;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	private void Update()
	{
	}

	protected override void OnShown()
	{
	}
}
