using SdA.AFrodoJourney.Core.Models.MovingBehaviors;

namespace SdA.AFrodoJourney.Core.Models
{
	public enum Weather
	{
		Sunshine,
		Raining,
		Storm,
		MegaRaining
	}

	public class WeatherMoving
	{
		private readonly Dictionary<Weather, IMoving> _movings = new()
		{
			{ Weather.Sunshine, new Charriot() },
			{ Weather.Raining, new Rabbit() },
			{ Weather.Storm, new Eagle() },
			{ Weather.MegaRaining, new Ent() },
		};

		public IMoving GetOne(Weather weather)
		{
			return this._movings[weather];
		}
	}
}
