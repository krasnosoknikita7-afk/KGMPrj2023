public struct LodData
{
	public float activateDistance;

	public bool isVisible;

	public bool shadows;

	public LodData(float activateDistance, bool isVisible, bool shadows)
	{
		this.activateDistance = 0f;
		this.isVisible = false;
		this.shadows = false;
	}
}
