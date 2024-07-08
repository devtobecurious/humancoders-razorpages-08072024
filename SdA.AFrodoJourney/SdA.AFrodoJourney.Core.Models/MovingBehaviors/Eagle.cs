namespace SdA.AFrodoJourney.Core.Models.MovingBehaviors
{
	public class Eagle : IMoving
	{
		public (int X, int Y) Move()
		{
			return (10, 10);
		}
	}
}
