using Travel.Entities.Airplanes;
using Travel.Entities.Airplanes.Contracts;
using Travel.Entities.Items;
using Travel.Entities.Items.Contracts;

namespace Travel.Core.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Contracts;
	using Entities;
	using Entities.Contracts;
	using Entities.Factories;
	using Entities.Factories.Contracts;

	public class AirportController : IAirportController
	{
		private const int BagValueConfiscationThreshold = 3000;

		private IAirport airport;
	    private IAirplaneFactory airplaneFactory; 
		private IItemFactory itemFactory;

		public AirportController(IAirport airport)
		{
			this.airport = airport;
			this.airplaneFactory = new AirplaneFactory();
			this.itemFactory = new ItemFactory();
		}

		public string RegisterPassenger(string name)
		{
			if (this.airport.GetPassenger(name) != null)
			{
				throw new InvalidOperationException($"Passenger {name} already registered!");
			}

			var passenger = new Passenger(name);
           
			this.airport.AddPassenger(passenger);

			return $"Registered {passenger.Username}";
		}

	    public string RegisterTrip(string source, string destination, string planeType)
	    {
	        IAirplane airplane = airplaneFactory.CreateAirplane(planeType);

	        ITrip trip = new Trip(source, destination, airplane);

	        this.airport.AddTrip(trip);

	        return $"Registered trip {trip.Id}";
	    }

        public string RegisterBag(string username, IEnumerable<string> bagItems)
		{
			IPassenger passenger = this.airport.GetPassenger(username);

			IItem[] items = bagItems.Select(i => itemFactory.CreateItem(i)).ToArray();

			IBag bag = new Bag(passenger, items);

			passenger.Bags.Add(bag);

			return $"Registered bag with {string.Join(", ", bagItems)} for {username}";
		}

	

		public string CheckIn(string username, string tripId, IEnumerable<int> bagIndices)
		{
			IPassenger passenger = this.airport.GetPassenger(username);
		    ITrip trip = airport.Trips.FirstOrDefault(i => i.Id == tripId);


            //CheckIn Pesho SofiaLondon1 0
            var checkedIn = airport.Trips.FirstOrDefault(t => t.Airplane.Passengers.Any(p => p.Username == username));
			if (checkedIn != null)
			{
				throw new InvalidOperationException($"{ username } is already checked in!");
			}

			var confiscatedBags = CheckInBags(passenger, bagIndices);
			trip.Airplane.AddPassenger(passenger);

			return
				$"Checked in {passenger.Username} with {bagIndices.Count() - confiscatedBags}/{bagIndices.Count()} checked in bags";
		}

		private int CheckInBags(IPassenger passenger, IEnumerable<int> bagsToCheckIn)
		{
			var bags = passenger.Bags;

			var confiscatedBagCount = 0;
			foreach (var i in bagsToCheckIn)
			{
				var currentBag = bags[i];
				bags.RemoveAt(i);

				if (ShouldConfiscate(currentBag))
				{
					airport.AddConfiscatedBag(currentBag);
					confiscatedBagCount++;
				}
				else
				{
					this.airport.AddCheckedBag(currentBag);
				}
			}

			return confiscatedBagCount;
		}

		private static bool ShouldConfiscate(IBag bag)
		{
			var shouldConfiscate = bag.Items.Sum(x => x.Value) > BagValueConfiscationThreshold;
			return shouldConfiscate;
		}
	}
}