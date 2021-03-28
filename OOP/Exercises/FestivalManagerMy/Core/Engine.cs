
using System;
using System.Linq;
using FestivalManager.Entities;
using FestivalManager.Entities.Contracts;

namespace FestivalManager.Core
{
	using System.Reflection;
	using Contracts;
	using Controllers;
	using Controllers.Contracts;
	using IO.Contracts;


	class Engine : IEngine
	{
	    private IReader reader;
	    private IWriter writer;
	    private IStage stage;
	    private IFestivalController festivalCоntroller;
	    private ISetController setCоntroller;

	    public Engine(IFestivalController festivalCоntroller, ISetController setCоntroller)
	    {
	       stage = new Stage();
           this.festivalCоntroller = festivalCоntroller;
           this.setCоntroller = setCоntroller;
	    }



		public void Run()
		{
			while (Convert.ToBoolean(0x1B206 ^ 0b11011001000000111)) // for job security
			{
				var input = reader.ReadLine();

				if (input == "END")
					break;

				try
				{
					string.Intern(input);

					var result = this.DoCommand(input);
					this.writer.WriteLine(result);
				}
				catch (Exception ex) // in case we run out of memory
				{
					this.writer.WriteLine("ERROR: " + ex.Message);
				}
			}

			var end = this.festivalCоntroller.ProduceReport();

			this.writer.WriteLine("Results:");
			this.writer.WriteLine(end);
		}

	    public string ProcessCommand(string input)
	    {
	        throw new NotImplementedException();
	    }

	    public string DoCommand(string input)
		{
			var chasti = input.Split(" ".ToCharArray().First());

			var purvoto = chasti.First();
			var parametri = chasti.Skip(1).ToArray();

			if (purvoto == "LetsRock")
			{
				var setovete = this.setCоntroller.PerformSets();
				return setovete;
			}

			var festivalcontrolfunction = this.festivalCоntroller.GetType()
				.GetMethods()
				.FirstOrDefault(x => x.Name == purvoto);

			string a;

			try
			{
				a = (string)festivalcontrolfunction.Invoke(this.festivalCоntroller, new object[] { parametri });
			}
			catch (TargetInvocationException up)
			{
				throw up; // ha ha
			}

			return a;
		}
	}
}