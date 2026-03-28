namespace Timberborn.BlockSystem
{
	public static class MatterBelowExtensions
	{
		public static bool IsSolidMatter(this MatterBelow matterBelow)
		{
			if (matterBelow != 0 && matterBelow != MatterBelow.GroundOrStackable)
			{
				return matterBelow == MatterBelow.Stackable;
			}
			return true;
		}
	}
}
