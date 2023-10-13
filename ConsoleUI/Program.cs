using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
        //BrandTest();
        //ColorTest();
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        var result = carManager.Add(new Car { CarName = "a", BrandId = 4, ColorId = 3, ModelYear = 2002, DailyPrice = 400, Description = "otomatik" });
        Console.WriteLine(result.Message);

        foreach (var c in carManager.GetCarDetails().Data)
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.BrandName + " >> " + c.ColorName);
        }

        Console.WriteLine("*******");

        //var car = carManager.GetCarDetailByCarId(2).Data;
        //Console.WriteLine(car.ModelYear + " >> " + car.DailyPrice + " >> " + car.BrandName + " >> " + car.ColorName);
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result = brandManager.GetAll();

        if (result.IsSuccess)
        {
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        var result = colorManager.GetAll();

        if (result.IsSuccess)
        {
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }
}