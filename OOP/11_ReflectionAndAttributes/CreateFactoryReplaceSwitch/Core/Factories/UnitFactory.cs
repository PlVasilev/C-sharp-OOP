using System.Linq;
using System.Reflection;

namespace P03_BarraksWars.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO

            Assembly assembly = Assembly.GetExecutingAssembly(); // GETTING ASSEMBLY returns all the things we can execute methods on them

            Type type = assembly.GetTypes()  // get the type of the class we want to create unit from
                 .FirstOrDefault(x => x.Name == unitType);

            IUnit instance = (IUnit)Activator.CreateInstance(type, true); // we create instance of type (IUnit)

            return instance;

        }
    }
}
