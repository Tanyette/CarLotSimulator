using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();





            var mazda = new Car();
            mazda.Year = 2016;
            mazda.Make = "Mazda";
            mazda.Model = "CX-5";
            mazda.EngineNoise = "Zoom, Zoom";
            mazda.HonkNoise = "beeeep";
            mazda.IsDrivable = true;

            carLot.ParkingLot.Add(mazda);


           var ford = new Car()
           {
               Year = 1995,
               Make = "Ford",
               Model = "Focus",
               EngineNoise = "rattle.rattle,rattle...",
               HonkNoise = "beep,beep",
               IsDrivable = false
           };

            carLot.ParkingLot.Add(ford);

            var jeep = new Car(2019, "Jeep", "Wrangler", "Vroom!", "BEEEP!", true);

            carLot.ParkingLot.Add(jeep);


            Console.WriteLine("Mazda");
            mazda.MakeEngineNoise(mazda.EngineNoise);
            mazda.MakeHonkNoise(mazda.HonkNoise);
            Console.WriteLine();


            Console.WriteLine("Ford");
            ford.MakeEngineNoise(ford.EngineNoise);
            ford.MakeHonkNoise(ford.HonkNoise);
            Console.WriteLine();


            Console.WriteLine("Jeep");
            jeep.MakeEngineNoise(jeep.EngineNoise);
            jeep.MakeHonkNoise(jeep.HonkNoise);

            Console.WriteLine();
            foreach(var car in carLot.ParkingLot) 
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}\n");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }



        }

            

    }



                                            




}      
    

