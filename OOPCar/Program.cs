using System;

namespace OOPCar
{
    class Program
    {   class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odometer;
            int fuel;

            public Car(string _mark, string _model, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"{mark} {model} {regNumber} has been created.");
            }

            public int Fuel
            {
                get { return fuel; }
            }

            public void Drive()
            {
                fuel -= 5;
                odometer += 100;
                Console.WriteLine("Vroom-vroom");
            }
            public void ShowCarData()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Registration number: {regNumber}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"odometer: {odometer}");
                Console.WriteLine($"Fuel: {Fuel}");
            }
        }
        
            
        
    
        static void Main(string[] args)
        {
            Car myCar = new Car("Porsche", "Panamera", "LOR582", "Black");
            while (myCar.Fuel > 0)
            {
                myCar.Drive();
            }
            myCar.ShowCarData();
        }
    }
}
