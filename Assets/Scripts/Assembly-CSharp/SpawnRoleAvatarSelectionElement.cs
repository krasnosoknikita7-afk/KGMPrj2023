using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpawnRoleAvatarSelectionElement : MonoBehaviour
{
	[SerializeField]
	private RawImage avatarImage;

	[SerializeField]
	private Image noAvatarImage;

	[SerializeField]
	private SpawnRolePreviewer spawnRolePreviewerPrefab;

	[SerializeField]
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	private int elementIndex;

	private int avatarId;

	private SpawnRolePreviewer spawnRolePreviewer;

	private UnityAction<int> onSelectedCallback;

	public void Initialize(int elementIndex, int avatarId, UnityAction<int> onSelectedCallback)
	{
	}

	public void OnSelected()
	{
	}

	public void SetupPreviewImage(GameObject spawnRoleObject)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void OnDestroy()
	{
	}
}
