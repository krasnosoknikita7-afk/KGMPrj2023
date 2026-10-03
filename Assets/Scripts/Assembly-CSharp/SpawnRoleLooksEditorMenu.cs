using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleLooksEditorMenu : MonoBehaviour
{
	[SerializeField]
	private RawImage spawnRoleAvatarPreviewImage;

	[SerializeField]
	private SpawnRoleAvatarSelectionMenu avatarSelectionMenuPrefab;

	[SerializeField]
	private SpawnRolePreviewer spawnRolePreviewerPrefab;

	[SerializeField]
	private int previewWidth;

	[SerializeField]
	private int previewHeight;

	private int spawnRoleId;

	private SpawnRolePreviewer spawnRolePreviewer;

	private MVAvatarSpawnRoleCreator spawnRole;

	private int renewPreviewerFrameDelay;

	public void Initialize(int spawnRoleId, MVAvatarSpawnRoleCreator spawnRole)
	{
	}

	private void OnSpawnRoleRedoObjectLinks()
	{
	}

	public void OnAvatarChangeButtonPressed()
	{
	}

	private void Update()
	{
	}

	private void SetupPreviewImage(GameObject spawnRolePreviewObject)
	{
	}

	private void OnSpawnRoleBodyUpdate()
	{
	}

	private void OnDestroy()
	{
	}
}
