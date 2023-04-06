using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Models.Interfaces;

namespace Task_2.Models
{
    public class Trailers : Vehicle, ICarWash
    {
        public Trailers(string model, string color, int year) : base(model, color, year)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("The Trailer makes a sound: VM VM");
        }

        public void WashCar(Cars car)
        {
            throw new NotImplementedException();
        }

        public void WashTrailer(Trailers trailer)
        {
            Console.WriteLine("The trailer is washed!");
        }
    }
}
