using System.ComponentModel.DataAnnotations;

namespace _1uzd_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car carBmw = new Car()

            {
                Model = "Car: BMW",
                Fuel = 40,
            };
            Car carHonda = new Car()
            {
                Model = "Car: Honda",
                Fuel = 60,
            };

            Bus busVolvo = new Bus()
            {
                Model = "Bus: Volvo",
                Fuel = 300,
            };

            Console.WriteLine(carBmw.Model);
            DriveAndReful(carBmw);
           
            Console.WriteLine(carHonda.Model);
            DriveAndReful(carHonda);

            Console.WriteLine(busVolvo.Model);
            DriveAndReful(busVolvo);

        }
        public static void DriveAndReful(IVehicle myCar)
        {
            Console.WriteLine("Kiek degalu liko: ");
            myCar.Drive();
            Console.WriteLine(myCar.GetFuel());

            Console.WriteLine("Kiek degalu po papildymo: ");
            myCar.Refuel(20);
            Console.WriteLine(myCar.GetFuel());
            Console.WriteLine();
        }
    }
}