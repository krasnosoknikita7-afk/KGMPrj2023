using UnityEngine;

public class KogamaLogHandlerTest : MonoBehaviour
{
	private ProxyLogHandler kogamaLogHandler;

	[SerializeField]
	private string s;

	[SerializeField]
	private LogType logType;

	private void Start()
	{
	}

	private void KogamaLogHandlerOnOnLogReceived(object sender, ProxyLogHandler.LogFormatData e)
	{
	}

	private void Update()
	{
	}
}
