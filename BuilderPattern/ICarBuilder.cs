using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface ICarBuilder
    {
        void AddSteeringCover();
        void AddSeatCover();
        void AddMobileStand();
        void AddHeadLight();
        ICar Build();
    }
}
