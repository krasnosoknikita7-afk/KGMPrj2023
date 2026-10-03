using UnityEngine;
using UnityEngine.Networking;

public class SoundLoader
{
	public delegate void UpdateSoundCallback();

	private string currentUrl;

	private string url;

	private AudioSource audioSource;

	public UpdateSoundCallback callback;

	public AudioSource AudioSource
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Url
	{
		set
		{
		}
	}

	public void LoadSound()
	{
	}

	public void Download(string soundUrl)
	{
	}

	private void OnDownloadFinished(UnityWebRequest www)
	{
	}

	public void Destroy()
	{
	}

	private void UpdateSound(AudioClip clip)
	{
	}

	public void StopAndDestroySound()
	{
	}
}
