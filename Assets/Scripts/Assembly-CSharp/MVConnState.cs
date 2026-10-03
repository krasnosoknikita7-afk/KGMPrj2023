public enum MVConnState
{
	Disconnected = 0,
	DisconnectedByUser = 1,
	Connecting = 2,
	Joining = 3,
	Joined = 4,
	Disconnecting = 5,
	Exception = 6,
	TimeoutDisconnect = 7,
	SendError = 8,
	HandlingException = 9
}
