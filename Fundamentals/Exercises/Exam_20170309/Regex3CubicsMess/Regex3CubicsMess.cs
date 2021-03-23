using System;
using System.Text.RegularExpressions;

namespace Regex3CubicsMess
{
    class Regex3CubicsMess
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());

            while (input != "Over!")
            {
                string pattern = $@"^([0-9]+)([A-Za-z]{{{m}}})?([0-9]*)[^a-zA-Z]*$";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string message = match.Groups[2].Value;
                    string verCode = match.Groups[1].Value;
                    if (match.Groups.Count > 2)
                    {
                        verCode += match.Groups[3].Value;

                    }
                    string result = "";
                    for (int i = 0; i < verCode.Length; i++)
                    {
                        int index = verCode[i]-48;
                        if (index >=0 && index < message.Length)
                        {
                            result += message[index];
                        }
                        else
                        {
                            result += " ";
                        }
                    }
                    Console.WriteLine($"{message} == {result}");
                }
                input = Console.ReadLine();
                m = int.Parse(Console.ReadLine());
            }

        }
    }
}
