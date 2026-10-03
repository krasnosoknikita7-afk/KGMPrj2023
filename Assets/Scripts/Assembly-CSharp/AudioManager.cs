using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public class Sound
	{
		public GameObject go;

		public AudioSource audio;
	}

	private GameObject poolTransform;

	private List<Sound> activeSounds;

	private List<Sound> pooledSounds;

	private List<int> soundsToRemove;

	private const int MaxPooledSoundObjects = 128;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public Sound Play(string name, AudioClip clip, Vector3 position, float volume, SoundRangeDistance range, float pitch = 1f)
	{
		return null;
	}

	public Sound Play(string name, AudioSource audioSource)
	{
		return null;
	}

	public Sound Play(string name, AudioSource audioSource, Vector3 position)
	{
		return null;
	}

	private static float GetMinDistanceFromRange(SoundRangeDistance range)
	{
		return 0f;
	}

	private static float GetMaxDistanceFromRange(SoundRangeDistance range)
	{
		return 0f;
	}
}
