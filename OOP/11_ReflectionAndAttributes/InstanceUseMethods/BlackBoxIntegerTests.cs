using System.Linq;
using System.Reflection;

namespace P02_BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type blackBoxInteger = typeof(BlackBoxInteger);
            var instance = (BlackBoxInteger)Activator.CreateInstance(blackBoxInteger, true);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string command = input.Split("_")[0];
                int value = int.Parse(input.Split("_")[1]);

                MethodInfo method = blackBoxInteger.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance) // we get some Method
                     .FirstOrDefault(x => x.Name == command);

                method.Invoke(instance, new object[]{value});  //INVOKE Изпълни се със INSTANCE HERE 

                var result = blackBoxInteger
                    .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                    .FirstOrDefault(f => f.Name == "innerValue")
                    .GetValue(instance);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }



        }
    }
}
