public class SimulasSoup : SmallExcercise
{
    public void Run()
    {
        (Form, Ingredient, Seasoning) soup = (Form.Stew, Ingredient.Mushrooms, Seasoning.Garlic);
        Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");
    }
}

public enum Form { Soup, Stew, Curry }
public enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes }
public enum Seasoning { Garlic, Cayenne, Ginger }