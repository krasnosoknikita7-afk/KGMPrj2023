using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Assets.Scripts.AdIntegration;
using MV.Common;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SendMessageControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COOMTest_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SendMessageControl _003C_003E4__this;

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
		public _003COOMTest_003Ed__58(int _003C_003E1__state)
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

	public UnityAction<bool> DoSend;

	public UnityAction SpamWarning;

	private const string showPerGameData = "/gp";

	private const string resetPlayerPlanetData = "/rgp";

	private const string helpString = "/h";

	private const string fps = "/f";

	private const string resolution = "/r";

	private const string mathTest = "/m";

	private const string chatCommands = "/c";

	private const string removeUI = "/ru";

	private const string switchAvatarTest = "/sat";

	private const string oomTest = "/oom";

	private const string urlTest = "/url";

	private const string testError = "/ter";

	private const string testException = "/tex";

	private const string testDateTime = "/dt";

	private const string enableHD = "/hd";

	private const string buildInformation = "/build";

	private const string exportTool = "/export";

	private const string exportSelfTool = "/exportself";

	private const string chatChangeCommandAll = "/all";

	private const string chatChangeCommandTeam = "/team";

	private const string chatChangeCommandSay = "/say";

	private const string allChat = "[ All ]";

	private const string teamChat = "[ Team ]";

	private const string sayChat = "[ Say ]";

	private const string startHeadShake = "/no";

	private const string startNod = "/yes";

	private const string startWave = "/wave";

	private const string fyberTestSuite = "/fyber";

	private const string showAd = "/ad";

	private const string PrintRegion = "/region";

	private const string pause = "/pause";

	private const string resume = "/resume";

	[SerializeField]
	private Text currentChat;

	[SerializeField]
	private InputField inputField;

	[SerializeField]
	private float intervalForMessages;

	[SerializeField]
	private int maxMessagesPerInterval;

	private Regex whiteSpaceCheck;

	private int frameCountSent;

	private const float sendMessageDelay = 0.01f;

	private float sendMessageCooldownTime;

	private List<float> spamList;

	private MVGameMsgType selectedChat;

	private bool isSayChatIconVisible;

	private Color sayChatColor;

	private List<byte> oomBytes;

	private int bytesPerFrame;

	public Color SayChatColor
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void InitializeToSayChat(bool sayChatVisible)
	{
	}

	private void OnDestroy()
	{
	}

	private void Send()
	{
	}

	public void OnInputFieldChange()
	{
	}

	private void EnforceCharacterLimit()
	{
	}

	private void SendChatMessage(string chatMsg)
	{
	}

	private bool HandleChatCommands(string chatMsg)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003COOMTest_003Ed__58))]
	private IEnumerator OOMTest()
	{
		return null;
	}

	private void OnAdShownCallback(InterstitialAdResult interstitialResult)
	{
	}

	private void OnAdShownCallback(RewardedAdResult result)
	{
	}

	private static void ShowBuildInformation()
	{
	}

	private static void ToggleHD()
	{
	}

	public static string CreateHelpTxt()
	{
		return null;
	}

	public static string CreateChatCommandsHelpTxt()
	{
		return null;
	}

	private static void SanitizeMessage(ref string message, string tagToSanitize)
	{
	}

	private bool HandleChatSwapCommand(string message)
	{
		return false;
	}

	private void SwapChat(MVGameMsgType newChat)
	{
	}

	private void ActivateAllChat()
	{
	}

	private void ActivateTeamChat()
	{
	}

	private void ActivateSayChat(bool sayChatVisible)
	{
	}

	private void ChangeTeamChatColor()
	{
	}

	public void SetToNextChat()
	{
	}

	private MVGameMsgType GetNextChat()
	{
		return MVGameMsgType.AvatarKilled;
	}

	public void OnInputFocusChange(bool isFocused)
	{
	}

	private void SetSayChatBubbleVisibleIfActive(bool visible)
	{
	}

	private void SetSayChatBubbleVisible(bool visible)
	{
	}
}
