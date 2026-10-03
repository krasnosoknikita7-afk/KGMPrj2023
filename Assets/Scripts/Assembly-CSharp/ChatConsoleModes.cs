using System.Collections.Generic;
using UnityEngine;

public class ChatConsoleModes : MonoBehaviour
{
	private ChatConsoleMode chatConsoleMode;

	[SerializeField]
	private List<ChatConsoleModeDef> chatConsoleModeDefs;

	public ChatConsoleMode ChatConsoleMode => ChatConsoleMode.ChatLobbyMode;

	public void Set(ChatConsoleMode chatConsoleMode, ref RectTransform rectTransform)
	{
	}
}
