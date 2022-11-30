using LTDO_1.Helpers;

namespace LTDO_1;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student()
        {
            Name = "Igor",
            Age = 21,
            StudentBag = new Bag()
            {
                Capacity = 5
            }
        };
        
        Console.WriteLine("Enter pizza pieces count");
        int pizzaPieces = int.Parse(Console.ReadLine()!);
        if (!BagHelper.AddPizza(pizzaPieces, student.StudentBag))
        {
            Console.WriteLine("Too much pizza");
            return;
        }
        
        Console.WriteLine("Enter beer bottles count");
        int beerBottles = int.Parse(Console.ReadLine()!);
        if (!BagHelper.AddBeer(beerBottles, student.StudentBag))
        {
            Console.WriteLine("Too much beer");
            return;
        }
        
        Console.WriteLine($"Student {student.Name}:\n" +
                          $"Has satiety state - {StudentHelper.CountSatiety(student)}\n" +
                          $"\tBecause he ate {student.StudentBag.PizzaPieces} pizzas\n" +
                          $"Has drunk state - {StudentHelper.CountDrunk(student)}\n" +
                          $"\tBecause he drunk {student.StudentBag.BeerBottles} bottles of beer");

    }
}