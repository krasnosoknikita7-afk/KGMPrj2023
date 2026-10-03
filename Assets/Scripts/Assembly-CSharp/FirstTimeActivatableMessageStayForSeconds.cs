using UnityEngine;

public class FirstTimeActivatableMessageStayForSeconds : FirstTimeActivatableMessage
{
	private float showedTime;

	private bool isShown;

	private bool isDone;

	[SerializeField]
	private string messageText;

	[SerializeField]
	private float stayTimeInSeconds;

	public override void OnShow()
	{
	}

	private void Update()
	{
	}

	protected override void OnDisable()
	{
	}
}
