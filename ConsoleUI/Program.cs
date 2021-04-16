using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.Entity_Framework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByDailyPrice(20,80))
            {
                Console.WriteLine("Car Id :"+car.CarId + "\nCar Name :"+car.Description);
            }
            
        }
    }
}
