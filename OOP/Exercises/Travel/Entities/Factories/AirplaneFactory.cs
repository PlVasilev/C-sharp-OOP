using System;
using System.Linq;
using System.Reflection;
using Travel.Entities.Airplanes;

namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;

	public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string type)
		{
		    Assembly assembly = Assembly.GetCallingAssembly(); // GETTING ASSEMBLY returns all the things we can execute methods on them

		    Type typeOfAssenbly = assembly.GetTypes()  // get the type of the class we want to create unit from
		        .FirstOrDefault(x => x.Name == type);

		    var instance = (IAirplane)Activator.CreateInstance(typeOfAssenbly, true); // we create instance of type (IUnit)

		    return instance;

            //switch (type)
            //{
            //	case "LightAirplane":
            //		return new LightAirplane();
            //	case "MediumAirplane":
            //		return new MediumAirplane();
            //	default:
            //		return null;
            //}
        }
	}
}