using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WinningConditionBriefing : LobbyFlowMenu
{
	[Serializable]
	private class WinningConditionBriefingDef
	{
		public WinningConditionType type;

		public Image scoreIconPrefab;

		public Image winConImagePrefab;
	}

	[CompilerGenerated]
	private sealed class _003CFixAspectRatioDelay_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinningConditionBriefing _003C_003E4__this;

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
		public _003CFixAspectRatioDelay_003Ed__34(int _003C_003E1__state)
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
	private GameObject winningConditionImageBackground;

	[SerializeField]
	private ProgressBar scoreProgressBar;

	[SerializeField]
	private Text scoreText;

	[SerializeField]
	private Text scoreSlash;

	[SerializeField]
	private Text scoreLimit;

	[SerializeField]
	private GameObject scoreGameObject;

	[SerializeField]
	private GameObject reachTheFlagPresent;

	[SerializeField]
	private Text flagScoreText;

	[SerializeField]
	private GameObject progressableWinningConditionPresent;

	[SerializeField]
	private ProgressBar roundTimeProgressBar;

	[SerializeField]
	private Text roundTimeText;

	[SerializeField]
	private Image roundTimeIconPrefab;

	[SerializeField]
	private Text winningConditionHeader;

	[SerializeField]
	private ScoreBoardController scoreBoardController;

	[SerializeField]
	private List<WinningConditionBriefingDef> winningConditionMapping;

	[SerializeField]
	private PlayButton DesktopPlayButtonPrefab;

	[SerializeField]
	private PlayButtonTouch AndroidPlayButtonPrefab;

	private WinningConditionType winConType;

	private bool isInitialized;

	private Action initializeCallback;

	private Image winConImage;

	private GameObject playButton;

	private PlayButton desktopPlayButton;

	private PlayButtonTouch androidPlayButton;

	private readonly Dictionary<WinningConditionType, string> headerMap;

	private Vector2 screensize;

	protected override LobbyFlowMenuType MenuType => LobbyFlowMenuType.LobbyState;

	public void Initialize(WinningConditionType winConType)
	{
	}

	public override void Start()
	{
	}

	private void SetupBriefing()
	{
	}

	private void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CFixAspectRatioDelay_003Ed__34))]
	private IEnumerator FixAspectRatioDelay()
	{
		return null;
	}

	private int GetHighScore(WinningConditionType winningConditionType)
	{
		return 0;
	}

	private void CreatePlayButton()
	{
	}

	private void OnPlayPressed()
	{
	}
}
