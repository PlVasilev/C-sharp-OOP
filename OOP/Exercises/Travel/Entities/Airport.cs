namespace Travel.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Contracts;
	
	public class Airport : IAirport
	{
		private List<IBag> checkedInBags;
		private List<IBag> confiscatedBags;
		private List<ITrip> trips;
		private List<IPassenger> passengers;

	    public Airport()
	    {
            checkedInBags = new List<IBag>();
	        confiscatedBags = new List<IBag>();
            trips = new List<ITrip>();
	        passengers = new List<IPassenger>();
	    }

	    public IReadOnlyCollection<IBag> CheckedInBags => checkedInBags;
	    public IReadOnlyCollection<IBag> ConfiscatedBags => confiscatedBags;
	    public IReadOnlyCollection<IPassenger> Passengers => passengers;
	    public IReadOnlyCollection<ITrip> Trips => trips;

	    public IPassenger GetPassenger(string username) => passengers.FirstOrDefault(p => p.Username == username);

	    public ITrip GetTrip(string id) => trips.FirstOrDefault(i => i.Id == id);

	    public void AddPassenger(IPassenger passenger) => passengers.Add(passenger);

	    public void AddTrip(ITrip trip) => trips.Add(trip);

	    public void AddCheckedBag(IBag bag) => checkedInBags.Add(bag);

	    public void AddConfiscatedBag(IBag bag) => confiscatedBags.Add(bag);
	}
}