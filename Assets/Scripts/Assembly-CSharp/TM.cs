using System;
using System.Collections.Generic;
using GNU.Gettext;
using UnityEngine.Networking;

public class TM
{
	private Catalog catalog;

	private string fileName;

	private bool languageLoadingDone;

	private readonly List<Action> languageChangedCallback;

	private string cultureName;

	private const string baseResourcesPath = "Languages/";

	private static TM instance;

	private static TM Instance => null;

	private TM()
	{
	}

	public static void Destroy()
	{
	}

	public static string _(string key)
	{
		return null;
	}

	public static void LanguageChanged(Action onLanguageChangedCallback)
	{
	}

	public static string GetTextWithValues(string index, ValueInsert values)
	{
		return null;
	}

	public static string[] GetTextAsArray(string toArrayString)
	{
		return null;
	}

	public static void LoadLanguage(string languageName)
	{
	}

	private static string GetFilename(string languageName)
	{
		return null;
	}

	private static void TryGetTextAsset(string fileName)
	{
	}

	private static void StreamingAssetCallback(UnityWebRequest www)
	{
	}

	private static void SetLanguageLoadingDone()
	{
	}

	private static string StripAssetStringFromFuncIdentifier(string key)
	{
		return null;
	}
}
