using System;
using System.Linq;
using System.Reflection;
using Travel.Entities.Airplanes.Contracts;

namespace Travel.Entities.Factories
{
	using Contracts;
	using Items;
	using Items.Contracts;

	public class ItemFactory : IItemFactory
	{
		public IItem CreateItem(string type)
		{
		    Assembly assembly = Assembly.GetCallingAssembly(); // GETTING ASSEMBLY returns all the things we can execute methods on them

		    Type typeOfAssenbly = assembly.GetTypes()  // get the type of the class we want to create unit from
		        .FirstOrDefault(x => x.Name == type);

		    var instance = (IItem)Activator.CreateInstance(typeOfAssenbly, true); // we create instance of type (IUnit)

		    return instance;

            //switch (type)
            //{
            //	case "CellPhone":
            //		return new CellPhone();
            //	case "Colombian":
            //		return new Colombian();
            //	case "Jewelery":
            //		return new Jewelery();
            //	case "Laptop":
            //		return new Laptop();
            //	case "Toothbrush":
            //		return new Toothbrush();
            //	case "TravelKit":
            //		return new TravelKit();
            //	default:
            //		return null;
            //}
        }
	}
}
