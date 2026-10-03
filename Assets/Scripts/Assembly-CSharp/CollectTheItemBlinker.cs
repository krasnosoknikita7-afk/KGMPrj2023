using UnityEngine;

public class CollectTheItemBlinker : BlinkerBase
{
	[SerializeField]
	private Color dropOffCollectedItemColor;

	[SerializeField]
	private Color DespawnColor;

	private void Awake()
	{
	}

	public void OnBlinkingActivated(bool shouldBlink, BlinkType type)
	{
	}

	public void DeactivateBlinking()
	{
	}
}
