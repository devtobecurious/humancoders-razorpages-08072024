using System.Diagnostics.CodeAnalysis;

namespace SdA.AFrodoJourney.Core.Models
{
	public class Step
	{
		#region Properties
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull]
		public required Location CurrentLocation { get; set; }

		public Person? MeetPerson { get; set; }
		#endregion
	}
}
