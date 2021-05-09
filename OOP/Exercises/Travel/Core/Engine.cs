using System;

namespace Travel.Core
{
    using System.Linq;
    using Contracts;
    using Controllers.Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IAirportController airportController;
        private IFlightController flightController;

        public Engine(IReader reader, IWriter writer, IAirportController airportController,
            IFlightController flightController)
        {
            this.reader = reader;
            this.writer = writer;
            this.airportController = airportController;
            this.flightController = flightController;
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine();
                string result;

                if (input == "END")
                {
                    break;
                }

                try
                {
                    result = this.ProcessCommand(input);

                }
                catch (System.InvalidOperationException ex)
                {
                    result = "ERROR: " + ex.Message;
                }

                writer.WriteLine(result.TrimEnd());
            }
        }

        public string ProcessCommand(string input)
        {
            //var tokens = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            //
            //string command = tokens[0];
            //
            //string result;
            //
            //if (command == "TakeOff" )
            //{
            //  result = flightController.TakeOff();
            //}
            //else
            //{
            //    string[] commandParams = tokens.Skip(1).ToArray();
            //
            //    var airplaneControllerMethods = airportController.GetType().GetMethods().FirstOrDefault(m => m.Name == command);
            //
            //    result = (string)airplaneControllerMethods.Invoke(this.airportController, new object[] { commandParams });
            //} 
            //
            //return result;
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            string[] args = tokens.Skip(1).ToArray();

            switch (command)
            {
                case "RegisterPassenger":
                    {
                        var name = args[0];
                        var output = this.airportController.RegisterPassenger(name);
                        return output;
                    }
                case "RegisterTrip":
                    {
                        var source = args[0];
                        var destination = args[1];
                        var planeType = args[2];

                        var output = this.airportController.RegisterTrip(source, destination, planeType);
                        return output;
                    }
                case "RegisterBag":
                    {
                        var username = args[0];
                        var bagItems = args.Skip(1);

                        var output = this.airportController.RegisterBag(username, bagItems);
                        return output;
                    }
                case "CheckIn":
                    {
                        var username = args[0];
                        var tripId = args[1];
                        var bagCheckInIndices = args.Skip(2).Select(Int32.Parse);

                        var output = this.airportController.CheckIn(username, tripId, bagCheckInIndices);
                        return output;
                    }
                case "TakeOff":
                    {
                        var output = this.flightController.TakeOff();
                        return output;
                    }
                default:
                    throw new System.InvalidOperationException("Invalid command!");
            }
        }
    }
}