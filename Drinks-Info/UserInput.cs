using System.ComponentModel.DataAnnotations;

namespace Drinks_Info;

public class UserInput
{
    DrinksService drinksService = new();

    internal void GetCategoriesInput()
    {
        drinksService.GetCategories();
		
		Console.WriteLine("Choose Category:");

		string category = Console.ReadLine();
		
		while (!Validation.IsStringValid(category))
		{
			Console.WriteLine("\n Invalid Category");
			category = Console.ReadLine();
		}

    }
}