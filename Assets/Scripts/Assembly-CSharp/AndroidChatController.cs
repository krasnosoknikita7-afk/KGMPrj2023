using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.UI;

public class AndroidChatController : MonoBehaviour
{
	private string adminMessageFormat;

	private string chatMessageFromFriend;

	private string chatMessageFormat;

	private const string teamMessageFormat = "<color=#{0}>[{1}] </color><color=#{2}>{3}: </color><color=#{4}>{5}</color>";

	private const string sayMessageFormat = "<color=#{0}>[{1}] </color><color=#{2}>{3}: </color><color=#{4}>{5}</color>";

	private string warningMessageFormat;

	private const int maxLineCount = 50;

	private Queue<Text> lines;

	private bool promptRegisterForChat;

	private const float sayHearingDistance = 15f;

	[SerializeField]
	private ChatConsoleModes chatConsoleModes;

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private ConsoleDragAndTapHandler enterChatButton;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private RectTransform inputAreaRoot;

	[SerializeField]
	private RectTransform expandChat;

	[SerializeField]
	private RectTransform minimizeChat;

	[SerializeField]
	private SendMessageControl messageController;

	[SerializeField]
	private Text consoleLinePrefab;

	[SerializeField]
	private RectTransform contentPanel;

	[SerializeField]
	private Color systemMessageColor;

	[SerializeField]
	private Color chatMessageColor;

	[SerializeField]
	private Color chatMessageDefaultNameColor;

	[SerializeField]
	private Color warningMessageColor;

	[SerializeField]
	private Color sayColor;

	public void Initialize()
	{
	}

	public void OnChatModeTapped()
	{
	}

	public void OnLobbyStateChange(bool inLobbyState)
	{
	}

	private void SetMode(ChatConsoleMode chatConsoleMode)
	{
	}

	private void ReceiveMessage(MVGameMsgType msgType, Dictionary<object, object> message)
	{
	}

	private void AddAdminMessage(Dictionary<object, object> data)
	{
	}

	private void AddWarningMessage(Dictionary<object, object> data)
	{
	}

	private void AddChatLine(Dictionary<object, object> data)
	{
	}

	private void AddLine(string text)
	{
	}

	private Text InstantiateNewLine()
	{
		return null;
	}

	private Text ReuseLine()
	{
		return null;
	}

	private void HandleTeamChatMessage(Dictionary<object, object> data)
	{
	}

	private string FormatTeamChatMessage(Dictionary<object, object> data)
	{
		return null;
	}

	private void HandleSayChatMessage(Dictionary<object, object> data)
	{
	}

	private void OnSayChatMessageHeard(Dictionary<object, object> data)
	{
	}

	private string FormatSayChatMessage(Dictionary<object, object> data)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
