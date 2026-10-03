using MV.WorldObject;
using UnityEngine;

public class GUICellCursor : MonoBehaviour
{
	public class Fader
	{
		private float start;

		private float end;

		private float durationInv;

		private float startMulDurationInv;

		private float startValue;

		private float endValue;

		public Fader(float duration, float startValue, float endValue)
		{
		}

		public bool Update(ref float fadeVal)
		{
			return false;
		}
	}

	private IntVector pos;

	public float fadeInTime;

	public float fadeOutTime;

	public float scale;

	private float baseAlpha;

	private float currentAlpha;

	private float prevCursorSetTime;

	public Material material;

	public float lineWidth;

	public bool lineMesh;

	public bool cubeMesh;

	public bool invertedCubeMesh;

	private Fader fader;

	private FadeState fadeState;

	[SerializeField]
	private MeshRenderer meshRenderer;

	[SerializeField]
	private MeshFilter meshFilter;

	public float PrevCursorSetTime => 0f;

	public IntVector LocalPos => default;

	public FadeOverride FadeOverride
	{
		set
		{
		}
	}

	public FadeState FadeState
	{
		get
		{
			return FadeState.Done;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void SetCursorCube(IntVector position, GameObject cubeGameObject)
	{
	}

	private void SetMaterialOpacity(float alphaValue)
	{
	}

	private void Update()
	{
	}

	public void Destroy()
	{
	}
}
