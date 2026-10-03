using System;
using System.Collections.Generic;
using Gamestrap;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class Styles : MonoBehaviour
{
	[Serializable]
	private class EffectStyleDef
	{
		[SerializeField]
		public EffectStyle effectStyle;

		[SerializeField]
		private bool shadow;

		[SerializeField]
		private Color shadowEffectColor;

		[SerializeField]
		private Vector2 shadowEffectDistance;

		[SerializeField]
		private bool shadowUseGraphicAlpha;

		[SerializeField]
		private bool outline;

		[SerializeField]
		private Color outlineEffectColor;

		[SerializeField]
		private Vector2 outlineEffectDistance;

		[SerializeField]
		private bool outlineUseGraphicAlpha;

		[SerializeField]
		private bool gradient;

		[SerializeField]
		private Color gradientTop;

		[SerializeField]
		private Color gradientBottom;

		public void Set(EffectStyleObject effectStyleObject)
		{
		}

		private void SetShadow(Shadow shadow)
		{
		}

		private void SetOutline(Outline outline)
		{
		}

		private void SetGradient(GradientEffect gradient)
		{
		}
	}

	[Serializable]
	private class ButtonStyleDef
	{
		[SerializeField]
		private ColorBlock colorBlock;

		[SerializeField]
		public ButtonStyle buttonStyle;

		public void Set(Button button)
		{
		}
	}

	[Serializable]
	private class TextStyleDef
	{
		[SerializeField]
		public TextStyle textStyle;

		[SerializeField]
		private Font font;

		[SerializeField]
		private int fontSize;

		[SerializeField]
		private FontStyle fontStyle;

		[SerializeField]
		private float lineSpacing;

		public void Set(Text text)
		{
		}
	}

	[Serializable]
	private class SoundStyleDef
	{
		[SerializeField]
		public SoundStyle soundStyle;

		[SerializeField]
		public AudioSource audioSource;
	}

	[Serializable]
	private class ColorStyleDef
	{
		[SerializeField]
		public ColorStyle colorStyle;

		[SerializeField]
		public Color color;

		public void Set(Graphic graphic)
		{
		}
	}

	[Serializable]
	private class TeamIconStyleDef
	{
		[SerializeField]
		public MVTeam team;

		[SerializeField]
		public Sprite sprite;
	}

	private static readonly Dictionary<MVTeam, ColorStyle> teamToColorStyle;

	private static readonly Dictionary<MVTeam, ColorStyle> teamToDarkColorStyle;

	private static Dictionary<ButtonStyle, ButtonStyleDef> buttonStylesDictionary;

	private static Dictionary<TextStyle, TextStyleDef> textStylesDictionary;

	private static Dictionary<ColorStyle, ColorStyleDef> colorStylesDictionary;

	private static Dictionary<MVTeam, TeamIconStyleDef> teamIconStylesDictionary;

	private static Dictionary<EffectStyle, EffectStyleDef> effectStylesDictionary;

	private static Dictionary<SoundStyle, AudioSource> soundStylesDictionary;

	private static Dictionary<AccessoryRarity, RarityStylesDef> accessoryRarityColorsDictionary;

	[SerializeField]
	private List<ButtonStyleDef> buttonStyles;

	[SerializeField]
	private List<TextStyleDef> textStyles;

	[SerializeField]
	private List<ColorStyleDef> colorStyles;

	[SerializeField]
	private List<TeamIconStyleDef> teamIconStyles;

	[SerializeField]
	private List<EffectStyleDef> effectStyles;

	[SerializeField]
	private List<SoundStyleDef> soundStyles;

	[SerializeField]
	private List<RarityStylesDef> rarityStyles;

	private static bool isInitialized;

	private void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public void Initialize()
	{
	}

	private static bool HandleUnInitalized()
	{
		return false;
	}

	public static void SetStyle(Button button, ButtonStyle buttonStyle, ColorStyle colorStyle, SoundStyle soundStyle)
	{
	}

	public static void SetStyle(Text text, TextStyle textStyle, ColorStyle colorStyle)
	{
	}

	public static void SetStyle(Graphic graphic, ColorStyle colorStyle)
	{
	}

	public static void SetStyle(Graphic image, MVTeam team)
	{
	}

	public static void SetStyle(Button button, ButtonStyle buttonStyle, MVTeam team, SoundStyle soundStyle = SoundStyle.NoSound)
	{
	}

	public static void SetStyle(EffectStyleObject effectStyleObject, EffectStyle effectStyle)
	{
	}

	public static Color GetTeamColor(MVTeam team, bool darkTeam = false)
	{
		return default;
	}

	public static ColorStyle GetTeamColorStyle(MVTeam team, bool darkTeam = false)
	{
		return (ColorStyle)0;
	}

	public static Color GetColor(ColorStyle colorStyle)
	{
		return default;
	}

	public static string ColorToHex(Color32 color)
	{
		return null;
	}

	public static Color HexToColor(string hex)
	{
		return default;
	}

	public static void TeamToSprite(Image image, MVTeam team)
	{
	}

	public static void PlayUISound(SoundStyle soundStyle)
	{
	}

	public static RarityStylesDef GetAccessoryColorsFromPrice(int price)
	{
		return null;
	}

	public static RarityStylesDef GetAccessoryColorsFromLevel(int level)
	{
		return null;
	}
}
