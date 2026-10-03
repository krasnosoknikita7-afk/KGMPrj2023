using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AvatarAccessoryPreviewer : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerClickHandler
{
	[CompilerGenerated]
	private sealed class _003CAnimationEndTrack_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float resetDelay;

		public AvatarAccessoryPreviewer _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAnimationEndTrack_003Ed__35(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private AvatarPreviewer previewer;

	[SerializeField]
	private RawImage toImage;

	[SerializeField]
	private int previewDimensionsX;

	[SerializeField]
	private int previewDimensionsY;

	[SerializeField]
	private float rotationSensitivity;

	[SerializeField]
	private float zoomSpeed;

	[SerializeField]
	private GameObject dropShadowPlane;

	private float currentRotationSpeed;

	private Transform avatarResetToTransform;

	private AvatarPreviewer toPreviewer;

	private const string mouseX = "Mouse X";

	private const string mouseY = "Mouse Y";

	private bool imagesReady;

	private int currentAnimation;

	private List<string> animations;

	private MVBody avatarBody;

	private GameObject bodyClone;

	private Animation goAnimation;

	private ActivateOnAnimationBase[] OnAnimationActivators;

	private const float animationLoopTimes = 3f;

	private float startFov;

	private bool pickedAccessory;

	public void SetupPreviewer(MVBody avatarBody)
	{
	}

	public void ResetPreviewTransform()
	{
	}

	private bool PickAccessory(Ray ray, out GameObject gameObject, out RaycastHit raycastHit)
	{
		gameObject = null;
		raycastHit = default;
		return false;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnDrag(PointerEventData data)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void ChangeAnimation()
	{
	}

	public void OnRestartAnimation()
	{
	}

	private void PlayAnimation()
	{
	}

	private void PlayAnimation(string animationName)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimationEndTrack_003Ed__35))]
	private IEnumerator AnimationEndTrack(float resetDelay)
	{
		return null;
	}

	private void RemoveSkinnedMeshOptimizers()
	{
	}
}
