using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Audi : ICarBuilder
    {
        private IMobileStand _mobileStand;
        private IHeadlight _headlight;
        private ISeatCover _seatCover;
        private ISteeringCover _steeringCover;

        public void AddSteeringCover()
        {
            _steeringCover=new SteeringCover();
        }

        public void AddSeatCover()
        {
            _seatCover=new SeatCover();
        }

        public void AddMobileStand()
        {
            _mobileStand=new MobileStand();
        }

        public void AddHeadLight()
        {
            _headlight=new Headlight();
        }

        public ICar Build()
        {
            return new Car(_steeringCover,_seatCover,_mobileStand, _headlight);
        }
    }
}
