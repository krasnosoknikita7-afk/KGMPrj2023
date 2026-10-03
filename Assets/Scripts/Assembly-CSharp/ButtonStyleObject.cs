using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonStyleObject : MonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private ButtonStyle buttonStyle;

	[SerializeField]
	private ColorStyle colorStyle;

	[SerializeField]
	private SoundStyle soundStyle;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}
}
