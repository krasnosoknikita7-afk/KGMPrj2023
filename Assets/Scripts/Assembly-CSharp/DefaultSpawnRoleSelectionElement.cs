using MV.Common;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class DefaultSpawnRoleSelectionElement : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	protected RawImage spawnRoleImage;

	[SerializeField]
	protected SpawnRolePreviewer spawnRolePreviewerPrefab;

	[SerializeField]
	protected int previewWidth;

	[SerializeField]
	protected int previewHeight;

	protected bool isSelected;

	protected int spawnRoleIndex;

	protected int woId;

	protected UnityAction<int> onSelectedCallback;

	protected UnityAction<int> onActivatedCallback;

	protected SpawnRolePreviewer spawnRolePreviewer;

	protected GameObject spawnRolePreviewObject;

	protected bool isDragging;

	public bool IsDragging
	{
		set
		{
		}
	}

	public int WOID => 0;

	public virtual GamePassTier Tier => GamePassTier.Tier0;

	public virtual void Initialize(int spawnRoleIndex, int woId, GamePassTier tierRequirement, MVTeam team, UnityAction<int> onSelectedCallback, UnityAction<int> onActivatedCallback)
	{
	}

	public void SetupPreviewImage(GameObject spawnRoleObject)
	{
	}

	private void ResetAvatarRenderers(GameObject avatarObject)
	{
	}

	public virtual void Select()
	{
	}

	public virtual void OnSelctionHighlight()
	{
	}

	public virtual void OnSelected()
	{
	}

	public virtual void OnUnSelected()
	{
	}

	public virtual void UpdateButtonUI()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	protected virtual void OnDestroy()
	{
	}
}
