using UnityEngine;
using UnityEngine.Events;

public class ContextMenu : MonoBehaviour
{
	private bool linkMenu;

	private Vector3 worldPosition;

	private int woID;

	[SerializeField]
	private ContextMenuButton contextMenuButtonPrefab;

	[SerializeField]
	private ContextMenuButton contextMenuLockedButtonPrefab;

	[SerializeField]
	private RectTransform rectTransform;

	public void Initialize(int woID, Vector3 worldPosition)
	{
	}

	public void InitializeLink(int linkID, Vector3 worldPosition)
	{
	}

	private void PopWoDestroyed(object obj, WorldObjectDestroyedEventArgs args)
	{
	}

	private void Pop()
	{
	}

	public void AddButton(string buttonText, UnityAction onClickCallback)
	{
	}

	public void AddLockedButton(string buttonText)
	{
	}

	private void Update()
	{
	}

	private void SetToScreenPoint()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}
}
