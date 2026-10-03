using Borodar.FarlandSkies.CloudyCrownPro.DotParams;
using ThemeTimers;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
	[Header("Configuration")]
	[SerializeField]
	[Range(0f, 100f)]
	private float _sunrise;

	[SerializeField]
	[Range(0f, 100f)]
	private float _sunset;

	[SerializeField]
	[Tooltip("Max angle between the horizon and the center of sun’s disk")]
	private float _sunAltitude;

	[SerializeField]
	[Tooltip("Angle between z-axis and the center of sun’s disk at sunrise")]
	private float _sunLongitude;

	[SerializeField]
	[Tooltip("A pair of angles that limit visible orbit of the sun")]
	private Vector2 _sunOrbit;

	[SerializeField]
	[Range(0f, 100f)]
	private float _moonrise;

	[SerializeField]
	[Range(0f, 100f)]
	private float _moonset;

	[SerializeField]
	[Tooltip("Max angle between the horizon and the center of moon’s disk")]
	private float _moonAltitude;

	[SerializeField]
	[Tooltip("Angle between z-axis and the center of moon’s disk at moonrise")]
	private float _moonLongitude;

	[SerializeField]
	[Tooltip("A pair of angles that limit visible orbit of the moon")]
	private Vector2 _moonOrbit;

	[Header("Dependencies")]
	[SerializeField]
	private ThemeSkybox skybox;

	[SerializeField]
	private DayNightCycleColorPresets colorPresets;

	private float _sunDuration;

	private Vector3 _sunAttitudeVector;

	private float _moonDuration;

	private Vector3 _moonAttitudeVector;

	private bool useServerTime;

	private float cycleLength;

	private ITimer timer;

	private float cycleStartTime;

	private bool initialized;

	private bool isPaused;

	private DayNightCycleColorPresets.Preset activeColorPreset;

	private float CurrentStepTime => 0f;

	private SkyParamsList _skyParamsList => null;

	private CelestialParamsList _sunParamsList => null;

	private CelestialParamsList _moonParamsList => null;

	private StarsParamsList _starsParamsList => null;

	public bool IsPaused
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int ColorPreset
	{
		set
		{
		}
	}

	public bool UseServerTime
	{
		set
		{
		}
	}

	public float InitialTimeOfDay
	{
		set
		{
		}
	}

	public float TimeOfDay
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float CycleLength
	{
		set
		{
		}
	}

	public float SunriseTime
	{
		set
		{
		}
	}

	public float SunsetTime
	{
		set
		{
		}
	}

	public float MoonriseTime
	{
		set
		{
		}
	}

	public float MoonsetTime
	{
		set
		{
		}
	}

	public float SunAltitude
	{
		set
		{
		}
	}

	public float SunLongitude
	{
		set
		{
		}
	}

	public float MoonAltitude
	{
		set
		{
		}
	}

	public float MoonLongitude
	{
		set
		{
		}
	}

	private SkyParam CurrentSkyParam { get; set; }

	private StarsParam CurrentStarsParam { get; set; }

	private CelestialParam CurrentSunParam { get; set; }

	private CelestialParam CurrentMoonParam { get; set; }

	private void EditorAssert(bool b)
	{
	}

	public void Initialize()
	{
	}

	public void Reset()
	{
	}

	private void RecalcSunDuration()
	{
	}

	private void RecalcSunAltitudeVector()
	{
	}

	private void RecalcMoonDuration()
	{
	}

	private void RecalcMoonAltitudeVector()
	{
	}

	protected void Update()
	{
	}

	private void Update(float timeOfDay)
	{
	}

	protected void OnValidate()
	{
	}
}
