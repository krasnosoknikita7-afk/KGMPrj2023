using UnityEngine;

public class MVQualitySettings : MonoBehaviour
{
	public delegate void OnQualityLevedChanged(int level);

	private static readonly LodData[] lodSettingsFastest;

	private static readonly LodData[] lodSettingsFast;

	private static readonly LodData[] lodSettingsSimple;

	private static readonly LodData[] lodSettingsGood;

	private static readonly LodData[] lodSettingsBeautiful;

	private static readonly LodData[] lodSettingsFantastic;

	private static readonly LodData[][] lodSettings;

	public const int QualitySD = 0;

	public const int QualityHD = 1;

	public const int QualitySDAndroid = 2;

	public static OnQualityLevedChanged onQualityLevelChanged;

	public static LodData[] CurrentLodData => null;

	public static int CurrentLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Start()
	{
	}
}
