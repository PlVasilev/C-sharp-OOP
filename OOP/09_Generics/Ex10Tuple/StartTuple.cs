using System;

namespace Ex10Tuple
{
   public class StartTuple
    {
        static void Main(string[] args)
        {
            string[] presonInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string fullName = presonInfo[0] + " " + presonInfo[1];
            string town = presonInfo[2];

            SpecialTuple<string,string,string> firsTuple = new SpecialTuple<string, string,string>(fullName,town,presonInfo[3]);
            Console.WriteLine(firsTuple.ToString());

            string[] personBearArr = Console.ReadLine().Split();
            string isDrunk;
            if (personBearArr[2] == "drunk")
            {
                isDrunk = "True";
            }
            else
            {
                isDrunk = "False";
            }
            SpecialTuple<string,int,string> personBrear = new SpecialTuple<string, int,string>(personBearArr[0],int.Parse(personBearArr[1]),isDrunk);
            Console.WriteLine(personBrear.ToString());

            string[] intDoubleArr = Console.ReadLine().Split();
            SpecialTuple<string,double,string> intDouble = new SpecialTuple<string, double,string>(intDoubleArr[0], double.Parse(intDoubleArr[1]),intDoubleArr[2]);
            Console.WriteLine(intDouble.ToString());
        }
    }
}
