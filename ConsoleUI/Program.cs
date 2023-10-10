using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var c in carManager.GetCarDetails())
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.BrandName + " >> " + c.ColorName);
        }

        Console.WriteLine("*******");

        var car = carManager.GetCarDetailByCarId(2);
        Console.WriteLine(car.ModelYear + " >> " + car.DailyPrice + " >> " + car.BrandName + " >> " + car.ColorName);
    }
}