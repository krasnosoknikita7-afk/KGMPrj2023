using System.Collections.Generic;
using MV.WorldObject;

public class DeltaCubes
{
	private readonly Queue<KeyValuePair<IntVector, CubeAction>> cubeChange;

	public Queue<KeyValuePair<IntVector, CubeAction>> CubeChange => null;

	public int Count => 0;

	public void Clear()
	{
	}

	public DeltaCubes()
	{
	}

	public DeltaCubes(IEnumerable<KeyValuePair<IntVector, CubeAction>> cubeChangeOriginal)
	{
	}

	public void Enqueue(IntVector iVector, CubeAction cubeAction)
	{
	}

	public byte[] Dequeue(RuntimePrototypeCubeModel rpcm)
	{
		return null;
	}
}
