using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car : ICar
    {
        private ISteeringCover _steeringCover;
        private ISeatCover _seatCover;
        private IMobileStand _mobileStand;
        private IHeadlight _headlight;

        public Car(ISteeringCover steeringCover, ISeatCover seatCover, IMobileStand mobileStand, IHeadlight headlight)
        {
            _steeringCover = steeringCover;
            _seatCover = seatCover;
            _mobileStand = mobileStand;
            _headlight = headlight;
        }

        public void Display()
        {
            Console.WriteLine("Car Features are: ");

            if( _steeringCover != null ) { Console.WriteLine("Steering Cover Added"); }
            if( _seatCover != null ) { Console.WriteLine("Seat Cover Added"); }
            if( _mobileStand != null ) { Console.WriteLine("Mobile Stand Cover Added"); }
            if(_headlight != null ) { Console.WriteLine("Headlight Added"); }
        }
    }
}
