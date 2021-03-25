using System;
using System.Text.RegularExpressions;

namespace Ex04Telephony
{
    class Ex04Telephony
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            string[] number = Console.ReadLine().Split();
            

            for (int i = 0; i < number.Length; i++)
            {
                Match match = Regex.Match(number[i], "^[0-9]+$");
                if (match.Success)
                {
                    smartPhone.Numbers.Add($"Calling... {number[i]}");
                }
                else
                {
                    smartPhone.Numbers.Add("Invalid number!");
                }
            }
            smartPhone.Call().ForEach(x => Console.WriteLine(x));

            string[] sites = Console.ReadLine().Split();
            for (int i = 0; i < sites.Length; i++)
            {
                Match match = Regex.Match(sites[i], "^[^0-9]+$");
                if (match.Success)
                {
                    smartPhone.Sites.Add($"Browsing: {sites[i]}!");
                }
                else
                {
                    smartPhone.Sites.Add("Invalid URL!");
                }
            }
            smartPhone.Brawse().ForEach(x => Console.WriteLine(x));
        }
    }
}
