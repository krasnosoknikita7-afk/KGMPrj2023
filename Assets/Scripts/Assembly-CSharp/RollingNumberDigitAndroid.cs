using UnityEngine;

public class RollingNumberDigitAndroid : MonoBehaviour
{
	[SerializeField]
	private RectTransform rollingDigitTransform;

	private int targetNumber;

	private float firstNumPosY;

	private float digitSize;

	private float currPos;

	private float targetPosY;

	private float currNumPos;

	private float rollingSpeed;

	private float rollTimer;

	public int Number
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
