using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {  
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //CarTest2();
            /*
            UsersManager usersManager = new UsersManager(new EfUserDal());
            var result = usersManager.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.Id+":"+user.FirstName+":"+user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }*/
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " : " + car.CarName + " : " + car.ColorName + " : " + car.DailyPrice);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    //colorManager.Add(new Color { Id = 8, Name = "bSF" });
        //    //colorManager.Delete(new Color { Id = 8, Name = "Purple" });
        //    // colorManager.Update(new Color { Id = 8, Name = "purple" });
        //    Console.WriteLine(colorManager.GetById(5).Id + "::" + colorManager.GetById(5).Name);
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.Id + " : " + color.Name);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + " : " + car.Description);
 
            }
        }
    }
}
