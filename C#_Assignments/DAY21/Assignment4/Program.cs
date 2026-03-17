namespace Assignment4
{
    internal class Program
    {
        class Vehicle
        {
            public int VehicleNumber { get; set; }
            private string Brand {  get; set; }

            public string brand
            {
                get
                {
                    return Brand;
                }
            }
            
            public void StartVehicle()
            {
                Console.WriteLine("Vehicle is starting..!");
            }
        }

        class Car : Vehicle
        {
            public string FuelType { get; set; }
        }

        public sealed class ElectricCar : Car
        {
            public void Display()
            {
                Console.WriteLine($"VehicleNumber: {VehicleNumber}");
                Console.WriteLine($"Brand: {brand}");
                Console.WriteLine($"FuelType: {FuelType}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ElectricCar car1 = new ElectricCar();
            car1.VehicleNumber = 1807;
            

        }
    }
}
