public struct Cell
{
	public Cube cube;

	public byte lightValue;

	public Cell(Cube cube)
	{
		this.cube = null;
		lightValue = 0;
	}

	public Cell Clone()
	{
		return default;
	}
}
