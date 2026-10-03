using UnityEngine;

public class FirstTimeActivatablePointerPlayerList : FirstTimeActivatableGotItPointer
{
	[SerializeField]
	private int playersRequiredForShowingPlayerList;

	public override bool CanShow => false;
}
