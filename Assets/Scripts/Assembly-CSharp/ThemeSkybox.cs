using System;
using UnityEngine;

public class ThemeSkybox : ThemeComponent
{
	[Serializable]
	private class PlatformSpecificMaterial
	{
		[SerializeField]
		private Material skyboxMaterialAndroid;

		[SerializeField]
		private Material skyboxMaterialStandalone;

		[SerializeField]
		private Material skyboxMaterialWebGL;

		public static implicit operator Material(PlatformSpecificMaterial m)
		{
			return null;
		}
	}

	[SerializeField]
	private PlatformSpecificMaterial skyboxMaterialSerialized;

	private Material skyboxMaterial;

	[SerializeField]
	[Tooltip("Color at the top pole of skybox sphere")]
	private Color _topColor;

	[Tooltip("Color at the bottom pole of skybox sphere")]
	[SerializeField]
	private Color _bottomColor;

	[SerializeField]
	private bool fogEnabled;

	[SerializeField]
	[Range(0f, 0.5f)]
	private float fogDensity;

	[SerializeField]
	private float fogStartDist;

	[SerializeField]
	private float fogEndDist;

	[SerializeField]
	private Color _starsTint;

	[SerializeField]
	[Range(0f, 10f)]
	[Tooltip("Reduction in stars apparent brightness closer to the horizon")]
	private float _starsExtinction;

	[SerializeField]
	[Range(0f, 25f)]
	[Tooltip("Variation in stars apparent brightness caused by the atmospheric turbulence")]
	private float _starsTwinklingSpeed;

	[SerializeField]
	private FlareLight _sun;

	[SerializeField]
	private Color _sunTint;

	[SerializeField]
	[Range(0.1f, 3f)]
	private float _sunSize;

	[SerializeField]
	[Range(0.01f, 2f)]
	[Tooltip("Actual flare brightness depends on sun tint alpha, and this property is just a coefficient for that value")]
	private float _sunFlareBrightness;

	[SerializeField]
	[Range(0f, 1f)]
	private float _sunLightContrast;

	[SerializeField]
	[Range(0f, 8f)]
	private float _sunLightIntensity;

	[SerializeField]
	private FlareLight _moon;

	[SerializeField]
	private Color _moonTint;

	[SerializeField]
	[Range(0.1f, 3f)]
	private float _moonSize;

	[SerializeField]
	[Range(0.01f, 2f)]
	[Tooltip("Actual flare brightness depends on moon tint alpha, and this property is just a coefficient for that value")]
	private float _moonFlareBrightness;

	[SerializeField]
	[Range(0f, 1f)]
	private float _moonLightContrast;

	[SerializeField]
	[Range(0f, 8f)]
	private float _moonLightIntensity;

	[SerializeField]
	[Range(-0.75f, 0.75f)]
	[Tooltip("Height of the clouds relative to the horizon")]
	private float _cloudsHeight;

	[Tooltip("Distance between the cloud waves")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _cloudsOffset;

	[Tooltip("Rotation of the clouds around the positive y axis")]
	[Range(-50f, 50f)]
	[SerializeField]
	private float _cloudsRotationSpeed;

	[Tooltip("Adjusts the brightness of the skybox")]
	[SerializeField]
	[Range(0f, 10f)]
	private float _exposure;

	[SerializeField]
	private AnimationCurve lightIntensityByEmitterHeight;

	private Material previousSkyboxMaterial;

	private CameraClearFlags previousClearFlags;

	private float sunAngle;

	private float moonAngle;

	public Material Material => null;

	public Color TopColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Color BottomColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public bool FogEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float FogDensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float FogStartDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float FogEndDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Color StarsTint
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float StarsExtinction
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float StarsTwinklingSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Light SunLight => null;

	public LensFlare SunFlare => null;

	public Color SunTint
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float SunSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SunLightContrast
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SunLightIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SunFlareBrightness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float SunHeight
	{
		set
		{
		}
	}

	public float SunAxisDegrees
	{
		set
		{
		}
	}

	public Quaternion SunRotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Light MoonLight => null;

	public LensFlare MoonFlare => null;

	public float MoonSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Color MoonTint
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float MoonLightContrast
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MoonLightIntensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MoonFlareBrightness
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MoonHeight
	{
		set
		{
		}
	}

	public float MoonAxisDegrees
	{
		set
		{
		}
	}

	public Quaternion MoonRotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float CloudsHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float CloudsOffset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float CloudsRotationSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Exposure
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private Skybox Skybox => null;

	private Camera Camera => null;

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	public void RecalculateSunLight()
	{
	}

	public void RecalculateMoonLight()
	{
	}

	public void RecalculateFogColor()
	{
	}

	private void ApplyRenderSettings()
	{
	}
}
