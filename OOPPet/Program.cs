using System;

namespace ConsoleApp1
{
    class Program
    {


        class Pet
        {
            string name;
            int age;
            double weight;
            //constructor
            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratulations! You ve adopted {name}!");
            }

            //getter for weight

            public double Weight
            {
                get { return weight; }

            }


            public void ShowPetInfo()
            {
                Console.WriteLine($"Name: {name}.");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");


            }

            public void Eat()
            {
                Console.WriteLine("Omnomnom");
                weight += 0.2; //weight = weight + 0.2
                
            }

            public void Run()
            {
                Console.WriteLine("Spin-spin-spin");
                weight -= 0.1;
                
            }

            public void GetOlder()
            {
                age++;
            }

            //desctructor

            //~Pet()
            //{
            //    Console.WriteLine($"RIP {name}");
            //}



        }



        static void Main(string[] args)
        {
            Pet myPet = new Pet("Hamster");
            myPet.ShowPetInfo();

            for (int i = 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($"Current weight: {myPet.Weight}");
                while(myPet.Weight > 0.7)
                {
                    myPet.Run();
                }

                /*if (myPet.Weight >= 0.7)
                  {
                        myPet.Run();
                  }*/
                myPet.GetOlder();
            }
            myPet.ShowPetInfo();
            
        }
    }
}