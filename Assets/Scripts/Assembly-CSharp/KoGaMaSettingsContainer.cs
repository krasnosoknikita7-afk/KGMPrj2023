using System;
using UnityEngine;

[Serializable]
public class KoGaMaSettingsContainer : ScriptableObject
{
	private struct CrunchDesc
	{
		public short data;

		public byte numOfBits;

		public CrunchDesc(int data, int numOfBits)
		{
			this.data = 0;
			this.numOfBits = 0;
		}
	}

	[SerializeField]
	[Header("Settings set by build system")]
	private bool showDebugLogin;

	[Header("Don't change")]
	[SerializeField]
	private TextAsset versionText;

	[SerializeField]
	private TextAsset additionalMetaData;

	[SerializeField]
	private int versionBuild;

	[SerializeField]
	private int streamingAssetVersion;

	[SerializeField]
	private string versionGuid;

	[SerializeField]
	private string branchName;

	[SerializeField]
	private string buildTime;

	[SerializeField]
	private KoGaMaSettingsContainer assetReference;

	public int VersionMajor => 0;

	public int VersionMinor => 0;

	public int VersionMicro => 0;

	public int VersionCode => 0;

	public string ReleaseName => null;

	public int LocalDiscCacheAssetVersion => 0;

	public string UrlCacheAssetVersionArgument => null;

	public string VersionGuid => null;

	public bool ShowDebugLogin => false;

	public string VersionString => null;

	public string VersionStringNoBuild => null;

	public string BranchName => null;

	public string BuildTime => null;

	public void InvalidateStreamingAssetsCache(bool serialize = true)
	{
	}

	public void SetStreamingAssetVersion(int version)
	{
	}
}
