using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Scripts.Subscription
{
	public class AdOrSubscriptionButton : MonoBehaviour
	{
		[SerializeField]
		private CooldownType cooldownType;

		[SerializeField]
		private GameObject countdownObject;

		[SerializeField]
		private Image countdownFillImage;

		[SerializeField]
		private Text countdownText;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private Sprite adSprite;

		[SerializeField]
		private Sprite subscriberSprite;

		[SerializeField]
		private Sprite buttonBackgroundActiveSprite;

		[SerializeField]
		private Sprite buttonBackgroundInactiveSprite;

		[SerializeField]
		private UnityEvent onAdClick;

		[SerializeField]
		private UnityEvent onSubscriberReadyClick;

		[SerializeField]
		private UnityEvent onSubscriberInCooldownClick;

		private bool isClickReady;

		private bool isSubscriber;

		private Image buttonBackgroundImage;

		private SubscriberCooldownsManager subCooldowns;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void OnClick()
		{
		}
	}
}
