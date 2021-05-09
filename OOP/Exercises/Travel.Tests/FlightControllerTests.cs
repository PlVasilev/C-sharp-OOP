


// REMOVE any "using" statements, which start with "Travel." BEFORE SUBMITTING

using Travel.Core.Controllers;
using Travel.Core.Controllers.Contracts;
using Travel.Entities;
using Travel.Entities.Airplanes;
using Travel.Entities.Airplanes.Contracts;
using Travel.Entities.Contracts;
using Travel.Entities.Items;
using Travel.Entities.Items.Contracts;

namespace Travel.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class FlightControllerTests
    {

        //Test isCompleted
        //Test CaryOnBaggage
        //Test If Airplane is Overbooked
        //Check if Trip is completed

        // triky part 1 id one unit test 
        //Airport
        //Trip
        //Airplane
        //Passager
        // bag -> Items

        [Test]
        public void Test1()
        {
            IAirport airport = new Airport();
            IAirplane airplane = new LightAirplane();
            Trip trip = new Trip("Sofia", "London", airplane);
            IPassenger passenger1 = new Passenger("Pesho");
            IPassenger passenger2 = new Passenger("Ivan");
            Item tootbrush = new Toothbrush();
            Item juewlery = new Jewelery();
            List<IItem> items = new List<IItem>();
            items.Add(tootbrush);
            items.Add(juewlery);
            IBag bag = new Bag(passenger1, items);
            passenger1.Bags.Add(bag);
            airport.AddTrip(trip);

            IFlightController flightController = new FlightController(airport);
            string result = flightController.TakeOff();

            string expepected =
                "SofiaLondon4:\r\nSuccessfully transported 0 passengers from Sofia to London.\r\nConfiscated bags: 0 (0 items) => $0";
            // "SofiaLondon4:\r\nSuccessfully transported 0 passengers from Sofia to London.\r\nConfiscated bags: 0 (0 items) => $0"
            Assert.AreEqual(expepected, result);

        }

        [Test]
        public void CheckIfTripIsCompleted()
        {
            var airport = new Airport();
            var airplane = new LightAirplane();
            var trip = new Trip("Tuk", "Tam", airplane);
            var passenger = new Passenger("Gosho");
            var bag = new Bag(passenger, new Item[] { new Colombian() });
            passenger.Bags.Add(bag);
            airport.AddTrip(trip);
            trip.Complete();

            var flightController = new FlightController(airport);

            var expectedResult = flightController.TakeOff();
            var actualResult = "Confiscated bags: 0 (0 items) => $0";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestIfAirplaneIsOverbooked()
        {
            var airport = new Airport();
            var airplane = new LightAirplane();
            var trip = new Trip("Tuk", "Tam", airplane);

            var passengers = new Passenger[10];

            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = new Passenger("Gosho" + i);
                airplane.AddPassenger(passengers[i]);
            }

            airport.AddTrip(trip);

            var flightController = new FlightController(airport);

            var expectedResult = flightController.TakeOff();
            var actualResult = "TukTam5:\r\nOverbooked! Ejected Gosho1, Gosho0, Gosho3, Gosho7, Gosho8\r\nConfiscated 0 bags ($0)\r\nSuccessfully transported 5 passengers from Tuk to Tam.\r\nConfiscated bags: 0 (0 items) => $0";

            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(trip.IsCompleted, true);
        }

        [Test]
        public void TestLoadCarryOnBaggage()
        {
            var airport = new Airport();

            var airplane = new LightAirplane();

            var passengers = new Passenger[10];

            //test if airplane is overbooked
            //Test load carry on baggage   
            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = new Passenger("Gosho" + i);
                airplane.AddPassenger(passengers[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    var bag = new Bag(passengers[i], new Item[] { new Colombian() });
                    passengers[i].Bags.Add(bag);
                }
                else
                {
                    var bag = new Bag(passengers[i], new Item[] { new Toothbrush() });
                    passengers[i].Bags.Add(bag);
                }
            }

            var trip = new Trip("Tuk", "Tam", airplane);
            airport.AddTrip(trip);

            var flightController = new FlightController(airport);

            var actualResult = flightController.TakeOff();
            var expectedResult = "TukTam6:\r\nOverbooked! Ejected Gosho1, Gosho0, Gosho3, Gosho7, Gosho8\r\nConfiscated 3 bags ($50006)\r\nSuccessfully transported 5 passengers from Tuk to Tam.\r\nConfiscated bags: 3 (3 items) => $50006";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SuccessfulTrip()
        {
            var passengers = new[]
            {
                new Passenger("Pesho1"),
                new Passenger("Pesho2"),
                new Passenger("Pesho3"),
                new Passenger("Pesho4"),
                new Passenger("Pesho5"),
                new Passenger("Pesho6"),
            };

            var airplane = new LightAirplane();

            foreach (var passenger in passengers)
            {
                airplane.AddPassenger(passenger);
            }

            var trip = new Trip("Sofia", "London", airplane);

            var airport = new Airport();

            airport.AddTrip(trip);

            var flightController = new FlightController(airport);

            var bag = new Bag(passengers[1], new[] { new Colombian() });

            passengers[1].Bags.Add(bag);

            var completedTrip = new Trip("Sofia", "Varna", new LightAirplane());
            completedTrip.Complete();

            airport.AddTrip(completedTrip);

            var actualResult = flightController.TakeOff();

            var expectedResult =
                @"SofiaLondon2:
Overbooked! Ejected Pesho2
Confiscated 1 bags ($50000)
Successfully transported 5 passengers from Sofia to London.
Confiscated bags: 1 (1 items) => $50000";

            Assert.That(actualResult, Is.EqualTo(expectedResult).NoClip);
            Assert.That(trip.IsCompleted, Is.True);
        }
    }
}
