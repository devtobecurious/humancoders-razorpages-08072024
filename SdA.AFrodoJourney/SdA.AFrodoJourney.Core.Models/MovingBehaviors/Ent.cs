namespace SdA.AFrodoJourney.Core.Models.MovingBehaviors
{
	public class Ent : IMoving
	{
		public (int X, int Y) Move()
		{
			return (5, 5);
		}
	}
}
