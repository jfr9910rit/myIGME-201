using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11Part1_Reester
{
    abstract class Vehicle
    {
        public virtual void LoadPassenger() { }
    }

    abstract class Car : Vehicle
    {

    }

    abstract class Train : Vehicle
    {

    }

    class Compact : Car, IPassengerCarrier
    {

    }

    class SUV : Car, IPassengerCarrier
    {

    }

    class Pickup : Car, IPassengerCarrier
    {

    }

    class PassengerTrain : Train, IPassengerCarrier
    {

    }

    class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }

    interface IPassengerCarrier
    {
        void LoadPassenger();
    }

    interface IHeavyLoadCarrier
    {

    }
}
