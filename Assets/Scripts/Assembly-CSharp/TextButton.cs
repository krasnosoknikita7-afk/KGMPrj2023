using UnityEngine;
using UnityEngine.UI;

public class TextButton : MonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private Text text;

	public Button Button => null;

	public Text Text => null;

	protected void Reset()
	{
	}
}
