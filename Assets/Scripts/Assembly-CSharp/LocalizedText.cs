using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LocalizedText : MonoBehaviour
{
	[SerializeField]
	private Text text;

	private void Awake()
	{
	}

	private void LanguageLoadedCallback()
	{
	}

	private void Reset()
	{
	}
}
