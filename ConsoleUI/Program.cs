using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager= new CarManager(new InMemoryCarDal());

        carManager.Add(new Car { Id = 5, BrandId = 3, ColorId = 1, ModelYear = 2023, DailyPrice = 450, Description = "Elektrikli,Otomatik" });
        carManager.Update(new Car { Id = 5, BrandId = 3, ColorId = 1, ModelYear = 2023, DailyPrice = 550, Description = "Elektrikli,Otomatik" });

        foreach (var c in carManager.GetAll())
        {
            Console.WriteLine(c.ModelYear +" >> "+c.DailyPrice+" >> "+c.Description);
        }
        Console.WriteLine("*******");
        carManager.Delete(new Car { Id = 5, BrandId = 3, ColorId = 1, ModelYear = 2023, DailyPrice = 450, Description = "Elektrikli,Otomatik" });

        foreach (var c in carManager.GetAll())
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.Description);
        }
        Console.WriteLine("*******");
        foreach (var c in carManager.GetByBrandId(2))
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.Description);
        }
        Console.WriteLine("*******");
        foreach (var c in carManager.GetByColorId(1))
        {
            Console.WriteLine(c.ModelYear + " >> " + c.DailyPrice + " >> " + c.Description);
        }
    }
}