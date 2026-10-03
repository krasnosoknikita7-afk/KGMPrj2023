using System;
using System.Collections.Generic;

public static class AvatarModifierPackageFactory
{
	private static Dictionary<AvatarModifierPackageType, AvatarModifierPackage> protoPackages;

	public static Func<float> Const(float c)
	{
		return null;
	}

	private static AvatarModifierPackage AssembleInvulnerabilityPackage(AvatarModifierPackageType type, float time)
	{
		return default;
	}

	public static AvatarModifierPackage GetPackage(AvatarModifierPackageType packageType)
	{
		return default;
	}
}
