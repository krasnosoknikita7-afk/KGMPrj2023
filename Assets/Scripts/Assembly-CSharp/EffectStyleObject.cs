using Gamestrap;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Graphic))]
[RequireComponent(typeof(ShadowEffect))]
[RequireComponent(typeof(Outline))]
[RequireComponent(typeof(GradientEffect))]
public class EffectStyleObject : MonoBehaviour
{
	[SerializeField]
	private EffectStyle effectStyle;

	[SerializeField]
	public Graphic graphic;

	[SerializeField]
	public ShadowEffect shadow;

	[SerializeField]
	public Outline outline;

	[SerializeField]
	public GradientEffect gradient;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}
}
