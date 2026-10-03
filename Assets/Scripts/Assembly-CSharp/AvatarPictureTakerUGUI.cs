using System;
using UnityEngine;

public class AvatarPictureTakerUGUI : MonoBehaviour
{
	public int previewResolution;

	private GameObject _avatarCloneGO;

	private BoneAnimation _boneAnimation;

	private bool isCurrentAvatarBody;

	[SerializeField]
	private Camera pictureCamera;

	public void TakePicture(MVWorldObjectClient avatar, int avatarIndex, Action<int, Texture2D> OnPictureTaken, bool isCurrentBody)
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPostRender()
	{
	}

	private void CleanupRenderTex()
	{
	}
}
