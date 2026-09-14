public class SoupedUpLabels : SmallExcercise
{
    public void Run()
    {
        (Form form, Ingredient ingredient, Seasoning seasoning) soup = (Form.Stew, Ingredient.Mushrooms, Seasoning.Garlic);
        Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.form}");
    }
}

// enums defined in SimulasSoup.cs