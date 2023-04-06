using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Models.Interfaces;

namespace Task_2.Models
{
    public class Cars : Vehicle, ICarWash, IGasPump
    {

        public Cars(string model, string color, int year) : base(model, color, year)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Car makes sound: BRM BRM");
        }

        public void PumpGas()
        {
            Console.WriteLine("The Car is filling with gas");
        }

        public void WashCar(Cars car)
        {
            Console.WriteLine("The car is being washed");
        }

        public void WashTrailer(Trailers trailer)
        {
            throw new NotImplementedException();
        }
    }
}
