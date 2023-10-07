using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager= new CarManager(new EfCarDal());

        //carManager.Add(new Car {CarName="bir şey", BrandId = 3, ColorId = 1, ModelYear = 2023, DailyPrice = 450, Description = "Elektrikli,Otomatik" });
        //carManager.Add(new Car { CarName = "bir şey", BrandId = 1, ColorId = 3, DailyPrice = 200, ModelYear = 2012, Description = "Dizel,Manuel" });
        carManager.Add(new Car { CarName = "bir şey", BrandId = 1, ColorId = 2, DailyPrice = 0, ModelYear = 2010, Description = "Benzinli,Manuel" });
        carManager.Add(new Car { CarName = "b", BrandId = 2, ColorId = 1, DailyPrice = 300, ModelYear = 2020, Description = "Dizel,Otomatik" });
        //carManager.Add(new Car { CarName = "bir şey" ,BrandId = 5, ColorId = 4, DailyPrice = 150, ModelYear = 2005, Description = "Benzinli,Otomatik" });

        foreach (var c in carManager.GetAll())
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.Description);
        }
        Console.WriteLine("*******");
        foreach (var c in carManager.GetCarsByBrandId(2))
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.Description);
        }
        Console.WriteLine("*******");
        foreach (var c in carManager.GetCarsByColorId(1))
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.Description);
        }
    }
}