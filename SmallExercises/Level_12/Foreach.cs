public class Foreach : SmallExcercise
{
    public void Run()
    {
        string[] names = ["Lexa", "Ada", "Skorin"];

        foreach (string name in names) 
        {
            Console.Write(name);
        }
    }
}
