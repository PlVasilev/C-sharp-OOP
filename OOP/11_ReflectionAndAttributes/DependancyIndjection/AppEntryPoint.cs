using System;
using DependancyInjection.Core.Command;

namespace _03BarracksFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using Microsoft.Extensions.DependencyInjection;

   public class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();

            //IRepository repository = new UnitRepository(); не ни трябват защото serviceProvider се грижи за тях
            //IUnitFactory unitFactory = new UnitFactory();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(serviceProvider);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices() 
        {
            IServiceCollection services = new ServiceCollection(); //  правим чанта със сървси 

            services.AddTransient<IUnitFactory, UnitFactory>(); // когато ти поискат IUnitFactory ти им дай UnitFactory
                                                                // (ако ти поискат интерфеис да им тоя обект) 
            // Transient е временен като поискаме UnitFacotry вика го и после го маха

            services.AddSingleton<IRepository, UnitRepository>(); // Singleton  е постоянен и стой през цялата програма веднъж извикан

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }

    }
}
 