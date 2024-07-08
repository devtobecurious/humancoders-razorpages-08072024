namespace SdA.AFrodoJourney.Core.Models.MovingBehaviors
{
	public class Charriot : IMoving
	{
		public (int X, int Y) Move()
		{
			return (2, 2);
		}
	}
}
