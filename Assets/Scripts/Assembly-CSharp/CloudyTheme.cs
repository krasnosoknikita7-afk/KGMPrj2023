using UnityEngine;

public class CloudyTheme : CloudyThemeBase
{
	[SerializeField]
	[Header("Meta")]
	private string identifier;

	[SerializeField]
	private string displayName;

	[SerializeField]
	private string description;

	public override string Identifier => null;

	public override string DisplayName => null;

	public override string Description => null;

	private string Validate(string str)
	{
		return null;
	}
}
