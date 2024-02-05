# Drinks-Info

This console application provides users with information about various drink categories and their respective drinks. It fetches data from "The Cocktail DB" API (http://www.thecocktaildb.com/api/json/v1/1) to display categories, drinks, and drink details.

### How to Use:

1. **Installation:**
   - Clone or download the application from the repository.

2. **Requirements:**
   - .NET Core SDK installed on your machine.

3. **Running the Application:**
   - Navigate to the root directory of the application in your terminal or command prompt.
   - Run the command `dotnet run` to start the application.

4. **Functionality:**
   - Upon running the application, users will be presented with a list of drink categories.
   - Users can select a category of drinks.
   - Once a category is selected, the application will display a list of drinks within that category.
   - Users can choose a specific drink to view its details.
   - Drink details include the name, category, type, glassware, ingredients, and instructions for preparation.

5. **User Input Validation:**
   - The application validates user input to ensure that entered categories and drink IDs are valid.

### Files:

- **Program.cs:**
  - Entry point of the application. It initializes user input.
  
- **DrinksService.cs:**
  - Handles API requests to retrieve categories, drinks by category, and drink details.

- **TableVisualisation.cs:**
  - Provides functionality to visualize data in a tabular format.

- **UserInput.cs:**
  - Manages user interaction, input validation, and navigation within the application.

- **Validation.cs:**
  - Contains methods for validating user input.

- **Models Directory:**
  - Contains class definitions for different data models used in the application.

### Dependencies:

- **RestSharp:** Used for making HTTP requests to the API.
- **Newtonsoft.Json:** Utilized for deserializing JSON responses from the API.

### Notes:

- The application relies on the availability and stability of "The Cocktail DB" API.
- Ensure a stable internet connection for the application to fetch data from the API successfully.
- Any changes to the API structure or endpoints may affect the application's functionality.
- Contributions and feedback are welcome. Feel free to fork the repository and submit pull requests.
