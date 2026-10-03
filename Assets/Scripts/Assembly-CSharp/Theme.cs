using System.Collections.Generic;
using ThemeSettings;
using UnityEngine;

public abstract class Theme : MonoBehaviour
{
	[SerializeField]
	private bool overrideSkyboxManager;

	[SerializeField]
	private RectTransform themeButtonImagePrefab;

	private List<ThemeComponent> components;

	public bool OverrideSkyboxManager => false;

	public RectTransform ThemeButtonImagePrefab => null;

	public abstract string Identifier { get; }

	public abstract string DisplayName { get; }

	public abstract string Description { get; }

	public SettingsWrapper Settings { get; private set; }

	public virtual List<RectTransform> Controllers => null;

	protected abstract void InitializeComponents();

	protected abstract void InitializeAttributes();

	public void InitializeForPreview()
	{
	}

	public void Initialize(int woid)
	{
	}

	private void Initialize()
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	public void Add(ThemeComponent component)
	{
	}

	public void Purchase(int id)
	{
	}

	public virtual void ThemeReset()
	{
	}
}
