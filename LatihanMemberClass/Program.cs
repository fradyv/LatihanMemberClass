using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket tiket1 = new PlaneTicket();
            PlaneTicket tiket2 = new PlaneTicket();

            tiket1.Origin = "JOGJA";
            tiket2.Origin = "JKT";
            tiket1.Destination = "PKU";
            tiket2.Destination = "PKU";
            tiket1.Cost = 100;
            tiket2.Cost = 750000;
            tiket1.Currency = "USD";
            tiket2.Currency = "IDR";

            Console.WriteLine("Origin: {0}", tiket1.Origin);
            Console.WriteLine("Destination: {0}", tiket1.Destination);

        }
    }
}
