using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models.Interfaces
{
    public interface ICarWash
    {
        void WashCar(Cars car);
        void WashTrailer(Trailers trailer);
    }
}
