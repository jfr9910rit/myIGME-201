using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PE11Part1_Reester;

namespace Traffic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPassengerCarrier iPassengerCarrier = null;
            Compact compact = new Compact();
            FreightTrain freightTrain = new FreightTrain();
            AddPassenger(compact);
            AddPassenger(freightTrain);

            void AddPassenger(Object vehicleObject)
            {
                iPassengerCarrier = (IPassengerCarrier) vehicleObject;
                iPassengerCarrier.LoadPassenger();
                Console.WriteLine(vehicleObject.ToString());
            }
        }
    }
}
