using Task_2.Models.Interfaces;

namespace Task_2.Models
{
    public class CarCenter : Vehicle, ICarWash, IGasPump, IRepairService
    {
        public CarCenter(string model, string color, int year) : base(model, color, year)
        {
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public void PumpGas()
        {
            throw new NotImplementedException();
        }

        public void WashCar(Cars car)
        {
            throw new NotImplementedException();
        }

        public void WashTrailer(Trailers trailer)
        {
            throw new NotImplementedException();
        }
    }
}
