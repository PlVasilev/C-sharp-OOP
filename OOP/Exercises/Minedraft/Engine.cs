
using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager draftManager;

    public Engine()
    {
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        while (true)
        {
            string command = input[0];
            List<string> args = input.Skip(1).ToList();
            string result = "";
            try
            {
                switch (command)
                {
                    case "RegisterHarvester":
                        result = draftManager.RegisterHarvester(args);
                        break;
                    case "RegisterProvider":
                        result = draftManager.RegisterProvider(args);
                        break;
                    case "Day":
                        result = draftManager.Day();
                        break;
                    case "Mode":
                        result = draftManager.Mode(args);
                        break;
                    case "Check":
                        result = draftManager.Check(args);
                        break;
                    case "Shutdown":
                        result = draftManager.ShutDown();
                        Console.WriteLine(result);
                        return;
                    default:
                        break;
                }
                Console.WriteLine(result);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

