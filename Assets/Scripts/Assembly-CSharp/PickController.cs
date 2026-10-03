using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PickController : MonoBehaviour
{
	[SerializeField]
	private Text woIDText;

	[SerializeField]
	private Text parentType;

	[SerializeField]
	private Text woType;

	[SerializeField]
	private PickHelper pickHelperPrefab;

	private UnityAction<int> pickCallback;

	private bool shouldSetText;

	private int pickedWoId;

	public void Initialize(UnityAction<int> onPickCallback, bool setText)
	{
	}

	public void SelectionChanged(MVWorldObjectClient wo, MVWorldObjectClient parent)
	{
	}

	public void Refresh()
	{
	}

	private int FindParentID(Transform t)
	{
		return 0;
	}
}
