using System;
using System.Collections;
using System.Collections.Generic;
using MV.WorldObject;

public class MVPlayerContainer : IEnumerator, IEnumerable<KeyValuePair<int, MVPlayer>>, IEnumerable
{
	private readonly Dictionary<int, MVPlayer> players;

	private readonly Dictionary<int, MVPlayer> pendingPlayers;

	private int localPlayerActorNumber;

	public Action OnPlayerListChanged;

	public Action OnPlayerListLoaded;

	public Action OnLocalPlayerReady;

	public Action OnLocalPlayerTeamChanged;

	public MVLocalPlayer LocalPlayer => null;

	public int Count => 0;

	public int PendingPlayersCount => 0;

	public Dictionary<int, MVPlayer>.ValueCollection Values => null;

	public Dictionary<int, MVPlayer>.ValueCollection ActivePlayers => null;

	public MVPlayer this[int actorNumber] => null;

	public object Current => null;

	public void SetLocalPlayer(int actorNumber)
	{
	}

	public bool TryGetPlayerByProfileId(int profileId, out MVPlayer player)
	{
		player = null;
		return false;
	}

	public void Add(MVPlayer player)
	{
	}

	public void Add(List<MVPlayer> playerList)
	{
	}

	public void Remove(int actorNr)
	{
	}

	public void UpdateTeam(int actorNr, MVTeam team)
	{
	}

	public void UpdateTeamForPlayersOnRemovedTeam(MVTeam removedTeam, MVTeam defaultTeam)
	{
	}

	public MVPlayer GetPlayerUnsafe(int actorNr)
	{
		return null;
	}

	public void SetPlayerReady(int actorNr, bool observer)
	{
	}

	public bool TryGetForStateChange(int actorNr, out MVPlayer player)
	{
		player = null;
		return false;
	}

	public bool TryGetValue(int actorNr, out MVPlayer player)
	{
		player = null;
		return false;
	}

	public bool ContainsKey(int actorNr)
	{
		return false;
	}

	public IEnumerator<KeyValuePair<int, MVPlayer>> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool MoveNext()
	{
		return false;
	}

	public void Reset()
	{
	}

	public void SendPlayerListEvents()
	{
	}
}
