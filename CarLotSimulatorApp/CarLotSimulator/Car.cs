using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }


        public Car() //Constructor  
        {

        }


        public Car(int year,string make,string model,string engineNoise,string honkNoise,bool isDrivable = false) 
        {
            Year = year;
            Make = Make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;

            
        }


        public void MakeEngineNoise(string EngineNoise) 
        {
            Console.WriteLine($"{ EngineNoise}");
        }

        public void MakeHonkNoise(string HonkNoise) 
        {
            Console.WriteLine($"{HonkNoise}");
        }
    }
}
