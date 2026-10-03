using MV.Common;

namespace Assets.Scripts.GamePasses
{
	public class TogglePreviewState
	{
		public readonly GamePassTier previewTier;

		private readonly GamePassTier currentTier;

		private bool freeTry;

		public bool FreeTryWithoutAdAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsOn => false;

		public bool CanToggle => false;

		public TogglePreviewState(GamePassTier previewTier, GamePassTier currentTier, bool freeFirstTry)
		{
		}
	}
}
