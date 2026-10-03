using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using WorldObjectTypes.HoverCraft.Shared;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Vehicles
{
	public class HoverCraftSettings : VehicleBaseSettings, IHandleSettingChanged, IEventSystemHandler
	{
		public static readonly Vector2 NormalEditingCanvasSize;

		private static readonly Vector2 ColorEditingCanvasSize;

		public const string Health = "overrideHealth";

		public const string RandomLeaveVehicle = "randomLeaveVehicle";

		public const string Speed = "speed";

		public const string JumpHeight = "jumpHeight";

		public const string ThrustersOn = "thrustersOn";

		public const string TurningSpeed = "turningSpeed";

		public const string ThrustersSize = "thrustersSize";

		public const string ThrustersColor = "thrustersColor";

		[SerializeField]
		private SettingsSlider healthSlider;

		[SerializeField]
		private SettingsInputFieldSlider healthInputField;

		[SerializeField]
		private SettingsSlider randomLeaveVehicleSlider;

		[SerializeField]
		private SettingsInputFieldSlider randomLeaveVehicleInputField;

		[SerializeField]
		private SettingsSlider speedSlider;

		[SerializeField]
		private SettingsInputFieldSlider speedInputField;

		[SerializeField]
		private SettingsSlider jumpHeightSlider;

		[SerializeField]
		private SettingsInputFieldSlider jumpHeightInputField;

		[SerializeField]
		private SettingsSlider turningSpeedSlider;

		[SerializeField]
		private SettingsInputFieldSlider turningSpeedInputField;

		[SerializeField]
		private SettingsToggle enginesOnToggle;

		[SerializeField]
		private SettingsSlider thrustersSizeSlider;

		[SerializeField]
		private SettingsInputFieldSlider thrustersSizeInputField;

		[SerializeField]
		private Image thrustersColorImage1;

		[SerializeField]
		private Image thrustersColorImage2;

		[SerializeField]
		private Image thrustersColorImage3;

		[SerializeField]
		private Image thrustersColorImage4;

		[SerializeField]
		private GameObject colorPicker;

		[SerializeField]
		private Image colorPickerPreview;

		[SerializeField]
		private SettingsSlider thrustersColorR;

		[SerializeField]
		private SettingsSlider thrustersColorG;

		[SerializeField]
		private SettingsSlider thrustersColorB;

		[SerializeField]
		private SettingsSlider thrustersColorAlpha;

		private int editingThrusterColor;

		public static readonly VehicleEnergyForVehicleSettingsConfig VehicleEnergyForVehicleSettingsConfig;

		protected override Vector2 DefaultCanvasSize => default;

		public override void Initialize(GameObject root)
		{
		}

		public override Dictionary<object, object> FillDefaultBlueprintData()
		{
			return null;
		}

		public override void BlueprintDataRetrieved()
		{
		}

		public override VehicleEnergyForVehicleSettingsConfig GetVehicleEnergySettingsConfig()
		{
			return default;
		}

		private static Color GetColorFromThrustersColor(ThrustersColor thrustersColor, int pos)
		{
			return default;
		}

		public void OnSettingChanged(string key, object value)
		{
		}

		public void OnColorPressed(int pos)
		{
		}

		public void OnColorEdited()
		{
		}
	}
}
