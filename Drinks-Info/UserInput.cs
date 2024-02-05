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

		GetDrinksInput(category);
    }

    private void GetDrinksInput(string category)
    {
	    drinksService.GetDrinksByCategory(category);
	    
	    Console.WriteLine("Choose a drink or go back to main menu by typing 0");
	    
	    
    }
}