using SdA.AFrodoJourney.Core.Models;
using SdA.AFrodoJourney.Core.Models.MovingBehaviors;

var frodo = new Person(new Footing());

//frodo.Move(new Eagle());
// frodo.Move(new Rabbit());

frodo.Move((new WeatherMoving()).GetOne(Weather.Storm));