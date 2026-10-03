using System.Collections.Generic;
using UnityEngine;

public class MVTriggerHandler : MonoBehaviour
{
	private Dictionary<int, TriggerBoxEvents> triggerBoxEvents;

	private Dictionary<int, TriggerBoxEvents> newTriggerBoxEvents;

	private Collider triggingCollider;

	private bool fixedUpdatedWasExecuted;

	private bool wasResetThisFrame;

	public Collider TriggingCollider => null;

	private void OnTriggerStay(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	private List<int> GetMissingKeysInDictionary(Dictionary<int, TriggerBoxEvents>.KeyCollection keys, Dictionary<int, TriggerBoxEvents> dictionary)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Reset()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}
}
