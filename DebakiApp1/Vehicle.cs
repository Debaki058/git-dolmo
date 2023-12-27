using
    System;

namespace DebakiApp1
{
    internal class Vehicle
    {
        public string brand = "Fold";
        public void honk()
        {
            Console.WriteLine("Tuut ,tuut");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }

    class Program
    {
        static void Main (string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Console.ReadKey();
        }
    }
}
