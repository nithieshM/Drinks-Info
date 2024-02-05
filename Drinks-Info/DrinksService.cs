using System.Web;
using Drinks_Info.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Drinks_Info;

public class DrinksService
{
    public void GetCategories()
    {
        var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1");
        var request = new RestRequest("list.php?c=list");
        var response = client.ExecuteAsync(request);

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string RawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<Categories>(RawResponse);

            List<Category> returnedList = serialize.CategoriesList;
            
            TableVisualisation.ShowTable(returnedList, "Categories Menu");
            Console.ReadKey();
        }
    }

    internal void GetDrinksByCategory(string category)
    {
        var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1");
        var request = new RestRequest($"filter.php?c={HttpUtility.UrlEncode(category)}");
        var response = client.ExecuteAsync(request);

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string RawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<Drinks>(RawResponse);

            List<Drink> returnedList = serialize.DrinksList;
            
            TableVisualisation.ShowTable(returnedList, "Categories Menu");
            Console.ReadKey();
        }
    }
}