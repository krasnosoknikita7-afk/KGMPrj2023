using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AvatarFader : MonoBehaviour, IFadeParent, IEventSystemHandler
{
	[Serializable]
	public struct ShaderFaderInstruction
	{
		public string originShader;

		public Shader originalShader;

		public Shader replacingShader;
	}

	[SerializeField]
	private ShaderFaderInstruction[] normalShaders;

	[SerializeField]
	private ShaderFaderInstruction[] fadeShaders;

	private Transform bodyTransform;

	private Dictionary<string, Shader> normalShadersDictionary;

	private Dictionary<string, Shader> fadeShadersDictionary;

	private string colorProperty;

	private string tintProperty;

	private List<Material> avatarMaterials;

	private bool fading;

	private bool changedShaders;

	private bool prevFading;

	public Transform BodyTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void SetTransparency(float fadeFactor)
	{
	}

	private Shader GetShader(Shader currShader, bool fading)
	{
		return null;
	}

	public void AddFadeMaterial(Material addRenderer)
	{
	}

	public void RemoveFadeMaterial(Material removeMaterial)
	{
	}
}
