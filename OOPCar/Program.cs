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
        }
        
            
        
    
        static void Main(string[] args)
        {
            Car myCar = new Car("porsche", "Panamera", "123qwe", "Black");
        }
    }
}
