using UnityEngine;

[CreateAssetMenu]
public class RegionConfigManager : ScriptableObject
{
	[SerializeField]
	private RegionConfig local;

	[SerializeField]
	private RegionConfig dev;

	[SerializeField]
	private RegionConfig test;

	[SerializeField]
	private RegionConfig friends;

	[SerializeField]
	private RegionConfig br;

	[SerializeField]
	private RegionConfig www;

	[SerializeField]
	private RegionConfig ut;

	[SerializeField]
	private TextAsset regionTag;

	private string RegionTag => null;

	public RegionConfig RegionConfig => null;
}
