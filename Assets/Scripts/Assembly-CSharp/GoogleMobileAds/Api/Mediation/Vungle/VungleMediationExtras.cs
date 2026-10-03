namespace GoogleMobileAds.Api.Mediation.Vungle
{
	public abstract class VungleMediationExtras : MediationExtras
	{
		public const string AllPlacementsKey = "all_placements";

		public const string UserIdKey = "user_id";

		public const string SoundEnabledKey = "sound_enabled";

		public override string IOSMediationExtraBuilderClassName => null;

		public VungleMediationExtras()
		{
		}

		public void SetAllPlacements(string[] allPlacements)
		{
		}

		public void SetUserId(string userId)
		{
		}

		public void SetSoundEnabled(bool soundEnabled)
		{
		}
	}
}
