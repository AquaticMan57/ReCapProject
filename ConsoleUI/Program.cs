using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarsMethod();
            //GetCarDetailsMethod();

        }

        private static void GetCarDetailsMethod()
        {
            CarManager manager = new CarManager(new EfCarDal());
            foreach (var car in manager.GetCarDetails())
            {
                Console.WriteLine(car.CarName);
            }
        }

        private static void GetCarsMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine("Car Model Year :" + car.ModelYear + "\nCar Name :" + car.CarName);
            }
            //PersonelManager personelManager = new PersonelManager(new EfPersonelDal());

            //foreach (var person in personelManager.GetAll())
            //{
            //    Console.WriteLine(person.Name);
            //}
        }
    }
}
