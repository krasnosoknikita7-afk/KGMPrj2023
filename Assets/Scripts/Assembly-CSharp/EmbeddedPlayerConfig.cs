using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu]
public class EmbeddedPlayerConfig : ScriptableObject
{
	private class JSONDomainObject
	{
		public string domain;
	}

	[SerializeField]
	public List<EmbeddedSiteConfigData> siteData;

	[SerializeField]
	public EmbeddedSiteConfigData kogamaDefaultData;

	[SerializeField]
	public EmbeddedSiteConfigData embeddedDefaultData;

	private bool initialized;

	private EmbeddedSiteConfigData currentSite;

	public void Initialize()
	{
	}

	private void OnURLSet(bool ok, string json)
	{
	}

	private void InitializeWithURL(string url)
	{
	}

	private static bool IsValidHost(string host, string[] hosts)
	{
		return false;
	}

	private static bool DoesHostMatch(string allowedHost, string[] applicationHost)
	{
		return false;
	}

	public EmbeddedSiteConfigData GetCurrentSiteData()
	{
		return default;
	}

	public void ForceEmbedSite(string url)
	{
	}

	public bool IsSite(EmbeddedSite embeddedSite)
	{
		return false;
	}
}
