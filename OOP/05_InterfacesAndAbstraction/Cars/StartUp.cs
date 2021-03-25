using System;

namespace Cars
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car seat = new Seat(); // polymorphysum we use base and make the Cild
            Console.WriteLine(seat.Start()); // base implementation
            Console.WriteLine(seat.Stop());  // overriten Stop()
            Tesla tesla = new Tesla();
            Console.WriteLine(tesla.Start()); //
            Console.WriteLine(tesla.Stop()); //
        }
    }
}
