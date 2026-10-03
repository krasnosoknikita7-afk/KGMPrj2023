using System;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI.Framework.Scripts.Shared.VehicleUI
{
	public class SpeedOMeter : VehicleMeterBase
	{
		public float fadeTime;

		[SerializeField]
		private CanvasGroup speedGroup;

		[SerializeField]
		private Text speedText;

		[SerializeField]
		private Text unitText;

		[SerializeField]
		private Text labelText;

		[SerializeField]
		private bool alwaysShow;

		public Action<bool, float> OnShowHide;

		private float curSpeed;

		private float currFade;

		private bool prevFading;

		private bool fading;

		private bool noHiding;

		private MVRigidBody rigidBody;

		private bool updateSpeed;

		public bool IsVisible => false;

		private void Awake()
		{
		}

		public override void Initialize(bool insideVehicle, MVRigidBody mvRigidBody)
		{
		}

		private void Fade()
		{
		}

		private void Show()
		{
		}

		public void UpdateSpeed()
		{
		}
	}
}
