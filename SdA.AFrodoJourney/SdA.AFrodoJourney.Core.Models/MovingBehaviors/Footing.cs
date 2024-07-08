namespace SdA.AFrodoJourney.Core.Models.MovingBehaviors
{
	public class Footing : IMoving
	{
		public (int X, int Y) Move()
		{
			return (1, 1);
		}
	}
}
