using System.Collections.Generic;

public class ReviveState
{
	private List<SafeSpotData> safePositions;

	private float minDistanceBetweenSafePositions;

	private int maxNumberOfSafePositions;

	private float safeSpotSuppressedTime;

	private float safeSpotSuppressedDuration;

	private int currentPreviewedSafePosition;

	public bool CanSafelySpawn => false;

	public SafeSpotData SafeGroundedData
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public void ResetSafePostions()
	{
	}

	public void SuppressSafeSpotSaving(float duration)
	{
	}

	public void SetSafeGroundedDataIndex(int index)
	{
	}

	public SafeSpotData GetSafeGroundedDataAtSelectedIndex()
	{
		return default;
	}

	public List<SafeSpotData> GetSafeGroundedPositions()
	{
		return null;
	}
}
