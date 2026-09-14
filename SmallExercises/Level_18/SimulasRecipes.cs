public class SimulasRecipes : SmallExcercise
{
    public void Run()
    {

        int choice = GetANumber("Please pick a number between 1 and 6: ");
        (Form form, Ingredient ingredient, Seasoning seasoning) soup;

        switch (choice)
        {
            case 1:
                soup = (Form.Stew, Ingredient.Mushrooms, Seasoning.Garlic);
                PrintSoup(soup);
                break;
            case 2:
                soup = (Form.Soup, Ingredient.Carrots, Seasoning.Cayenne);
                PrintSoup(soup);
                break;
            case 3:
                soup = (Form.Curry, Ingredient.Potatoes, Seasoning.Ginger);
                PrintSoup(soup);
                break;
            case 4:
                soup = (Form.Curry, Ingredient.Chicken, Seasoning.Cayenne);
                PrintSoup(soup);
                break;
            case 5:
                soup = (Form.Soup, Ingredient.Chicken, Seasoning.Garlic);
                PrintSoup(soup);
                break;
            case 6:
                soup = (Form.Stew, Ingredient.Carrots, Seasoning.Ginger);
                PrintSoup(soup);
                break;
            default:
                Console.WriteLine("Invalid choice...");
                break;
        }
    }

    private int GetANumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    private void PrintSoup((Form form, Ingredient ingredient, Seasoning seasoning) soup)
    {
        Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.form}");
    }
}

// enums defined in SimulasSoup.cs