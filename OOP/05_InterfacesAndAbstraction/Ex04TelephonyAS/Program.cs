using System;

namespace _04TelephonyAUT
{
    class Program
    {
        public static void Main()
        {
            var phone = new Smartphone("Smartphone");
            TestPhone(phone);
        }

        private static void TestPhone(ISmartphone phone)
        {
            var numbersToCall = Console.ReadLine().Split();

            foreach (var number in numbersToCall)
            {
                Console.WriteLine(phone.Call(number));
            }

            var sitesToBrowse = Console.ReadLine().Split();

            foreach (var site in sitesToBrowse)
            {
                Console.WriteLine(phone.Browse(site));
            }
        }
    }
}
