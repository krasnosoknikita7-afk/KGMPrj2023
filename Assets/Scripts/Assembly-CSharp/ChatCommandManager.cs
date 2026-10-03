using System;
using System.Collections.Generic;

public static class ChatCommandManager
{
	private static Dictionary<ChatCommand, Action> chatCommandCallBackDictionary;

	public static Action GetChatCommandCallback(ChatCommand chatCommand)
	{
		return null;
	}

	public static void UpdateChatCommandCallback(ChatCommand chatCommand, Action callback)
	{
	}

	public static void ChatCommandActivated(ChatCommand chatCommand)
	{
	}
}
