namespace SdA.AFrodoJourney.Core.Models
{
	public class Journey
	{
		#region Constructors
		public Journey(params Step[] steps)
		{
			this.Steps.AddRange(steps);
		}
		#endregion

		#region Properties
		public List<Step> Steps { get; private set; } = new List<Step>();
		#endregion
	}
}
