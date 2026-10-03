using UnityEngine;

public class MeshDataPool
{
	private const int maxVertices = 786432;

	private const int maxIndices = 1179648;

	private int vertexPos;

	private readonly Vector3[] vertices;

	private int uvPos;

	private readonly Vector2[] uvs;

	private int colorPos;

	private readonly Color[] colors;

	private int indicesPos;

	private readonly int[] indices;

	private static MeshDataPool instance;

	private static int VertexPos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static Vector3[] Vertices => null;

	private static int UvPos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static Vector2[] Uvs => null;

	private static int ColorPos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static Color[] Colors => null;

	private static int IndicesPos
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static int[] Indices => null;

	public static void Create()
	{
	}

	public static void Destroy()
	{
	}

	public static void AddVertex(Vector3 vertex)
	{
	}

	public static Vector3[] GetVertices()
	{
		return null;
	}

	public static void AddUv(Vector2 uv)
	{
	}

	public static Vector2[] GetUvs()
	{
		return null;
	}

	public static void AddUvRange(Vector2[] uvRange)
	{
	}

	public static void AddColor(Color color)
	{
	}

	public static Color[] GetColors()
	{
		return null;
	}

	public static void AddIndex(int index)
	{
	}

	public static int[] GetIndices()
	{
		return null;
	}

	public static void Reset()
	{
	}
}
