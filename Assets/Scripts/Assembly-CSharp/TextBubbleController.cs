using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextBubbleController : MonoBehaviour, IEventSystemHandler
{
	private class BubbleTracker
	{
		public float timeToLive;

		public float currentLifeTime;

		private TextBubble bubble;

		public TextBubble Bubble
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Clear()
		{
		}
	}

	[SerializeField]
	[Header("Configuration")]
	private float bubbleLifeTime;

	[SerializeField]
	private float bubbleFadeIn;

	[SerializeField]
	[Header("Dependencies")]
	private TextBubble textBubblePrefab;

	[SerializeField]
	private Text textPrefab;

	private Dictionary<int, BubbleTracker> textBubbles;

	private const int maxNumOfBubbles = 40;

	private int currentBubbleId;

	private Camera mainCamera;

	private List<int> removeList;

	private void Start()
	{
	}

	public int ShowBubble3D(Vector3 worldPosition, string text, float lifeTime, Transform parentTransform, int bubbleId, bool positionUpdate = true, bool contentUpdate = false)
	{
		return 0;
	}

	public int ShowBubble3D(Vector3 worldPosition, float lifeTime, List<RectTransform> content, Transform parentTransform, Vector2 offset)
	{
		return 0;
	}

	public void UpdatePosition3D(int bubbleId, Vector3 worldPosition, Vector2 offset)
	{
	}

	private Vector3 CalculateOffSet(Vector2 offset, Vector3 screenSpacePos)
	{
		return default;
	}

	public int ShowBubble2D(Vector2 anchoredPosition, Vector2 targetCenterPoint, float lifeTime, List<RectTransform> content, Transform parentTransform)
	{
		return 0;
	}

	public void UpdateContent(int bubbleId, List<RectTransform> content)
	{
	}

	public void UpdatePosition(int bubbleId, Vector2 anchoredPosition, Vector2 targetCenterPoint)
	{
	}

	public void AddFirstElement(int bubbleId, RectTransform element)
	{
	}

	public void AddElement(int bubbleId, RectTransform element)
	{
	}

	public void ClearBubblesWithId(int bubbleId)
	{
	}

	public void ClearBubblesOfTypeImmediately(int bubbleId)
	{
	}

	protected void Update()
	{
	}

	private bool UpdateBubble(BubbleTracker bubble)
	{
		return false;
	}
}
