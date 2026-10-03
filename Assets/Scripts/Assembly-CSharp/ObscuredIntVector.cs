using CodeStage.AntiCheat.ObscuredTypes;
using MV.WorldObject;
using UnityEngine;

public struct ObscuredIntVector
{
	public ObscuredShort x;

	public ObscuredShort y;

	public ObscuredShort z;

	public static readonly ObscuredIntVector One;

	public short this[int key]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ObscuredIntVector iV)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(ObscuredIntVector a, ObscuredIntVector b)
	{
		return false;
	}

	public static bool operator !=(ObscuredIntVector a, ObscuredIntVector b)
	{
		return false;
	}

	public ObscuredIntVector(short x, short y, short z)
	{
		this.x = default;
		this.y = default;
		this.z = default;
	}

	public ObscuredIntVector(int x, int y, int z)
	{
		this.x = default;
		this.y = default;
		this.z = default;
	}

	public ObscuredIntVector(IntVector intVector)
	{
		x = default;
		y = default;
		z = default;
	}

	public ObscuredIntVector(float x, float y, float z)
	{
		this.x = default;
		this.y = default;
		this.z = default;
	}

	public Vector3 ToVector3()
	{
		return default;
	}

	public override string ToString()
	{
		return null;
	}

	public static ObscuredIntVector operator +(ObscuredIntVector i1)
	{
		return default;
	}

	public static ObscuredIntVector operator -(ObscuredIntVector i1)
	{
		return default;
	}

	public static ObscuredIntVector operator +(ObscuredIntVector i1, ObscuredIntVector i2)
	{
		return default;
	}

	public static ObscuredIntVector operator -(ObscuredIntVector i1, ObscuredIntVector i2)
	{
		return default;
	}

	public static ObscuredIntVector operator *(int i, ObscuredIntVector iV)
	{
		return default;
	}

	public static ObscuredIntVector operator *(ObscuredIntVector iV, int i)
	{
		return default;
	}

	public static Vector3 operator *(ObscuredIntVector iV, Vector3 vector3)
	{
		return default;
	}

	public static ObscuredIntVector operator /(ObscuredIntVector iV, int i)
	{
		return default;
	}

	public int SquareMagnitude()
	{
		return 0;
	}

	public static int ObscuredIntVectorToIndex(ObscuredIntVector ObscuredIntVector, int chunkSize)
	{
		return 0;
	}

	public static ObscuredIntVector IndexToObscuredIntVector(int index, int chunkSize)
	{
		return default;
	}
}
