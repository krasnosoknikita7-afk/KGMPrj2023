using MV.WorldObject.Subscription;
using UnityEngine;

public class SubscriberBenefitUIHandler : MonoBehaviour
{
	[SerializeField]
	private GameObject SubscriberUI;

	[SerializeField]
	private GameObject NonSubscriberUI;

	[SerializeField]
	private SubscriptionBenefit benefitType;

	private void Start()
	{
	}
}
