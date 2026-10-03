using System.Collections;
using System.Collections.Generic;

public class SelfElevator
{
	public enum ApplicationIntegrityLevel
	{
		Untrusted = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		System = 4,
		Unknown = 5
	}

	private enum Bools
	{
		inAdminGroupSet = 0,
		inAdminGroup = 1,
		isRunningAsAdminSet = 2,
		isRunningAsAdmin = 3,
		isElevatedSet = 4,
		isElevated = 5,
		Size = 6
	}

	private static BitArray bits;

	private static ApplicationIntegrityLevel integrityLevel;

	private Dictionary<int, ApplicationIntegrityLevel> RID_to_ApplicationIntegrityLevel;

	public static bool InAdminGroupSet => false;

	public static bool InAdminGroup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsRunningAsAdminSet => false;

	public static bool IsRunningAsAdmin
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsElevatedSet => false;

	public static bool IsElevated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ApplicationIntegrityLevel IntegrityLevel
	{
		get
		{
			return ApplicationIntegrityLevel.Untrusted;
		}
		set
		{
		}
	}

	internal bool IsUserInAdminGroup()
	{
		return false;
	}

	internal bool IsRunAsAdmin()
	{
		return false;
	}

	internal bool IsProcessElevated()
	{
		return false;
	}

	internal int GetProcessIntegrityLevel()
	{
		return 0;
	}

	private string GetExecutableName()
	{
		return null;
	}

	public void Elevate()
	{
	}
}
