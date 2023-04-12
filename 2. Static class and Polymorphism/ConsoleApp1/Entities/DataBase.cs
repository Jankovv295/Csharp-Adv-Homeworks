namespace ConsoleApp1.Entities
{
    public static class DataBase
    {
        public static List<Vehicle> Vehicles;

        public static void VehiclesDB()
        {
            Car bmw = new Car()
            {
                Id = 1,
                YearOfProduction = 2020,
                Countries = "Germany",
                BatchNumber = 11243,
                FuelTank = 50,
                Type = "X5"
            };
            Vehicles.Add(bmw);

            Car alfaRomeo = new Car()
            {
                Id = 2,
                YearOfProduction = 2020,
                Countries = "Italy",
                BatchNumber = 11242443,
                FuelTank = 40,
                Type = "SUV"
            };
            Vehicles.Add(alfaRomeo);


            Bike velosiped = new Bike()
            {
                Id = 3,
                BatchNumber = 50,
                Type = "Tocak",
                YearOfProduction = 2022,
                Color = "Green"
            };
            Vehicles.Add(velosiped);


            Bike tocak = new Bike()
            {
                Id = 4,
                BatchNumber = 52,
                Type = "Tocak",
                YearOfProduction = 2015,
                Color = "Gray"
            };
            Vehicles.Add(tocak);


            Vehicle kamion = new Vehicle()
            {
                Id = 5,
                YearOfProduction = 2013,
                Type = "kamion",
                BatchNumber = 43
            };
            Vehicles.Add(kamion);

        }

        public static string Validator(Vehicle vehicle)
        {
            if (vehicle.Id > 0)
            {
                if (vehicle.YearOfProduction > 0)
                {
                    if (string.IsNullOrEmpty(vehicle.Type))
                    {
                        return "ERROR: The type of the vehicle cannot be empty or null";
                    }
                    else
                    {
                        return vehicle.Type.ToString() + " " + vehicle.YearOfProduction.ToString() + " " +  vehicle.Id.ToString();
                    }
                }
                else return "ERROR: The Year of Production cannot have value 0 or less";

            }
            else return "ERROR: The Id cannot have value 0 or less";

        }
    }
}
