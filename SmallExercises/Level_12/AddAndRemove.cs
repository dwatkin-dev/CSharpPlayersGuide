public class AddAndRemove : SmallExcercise
{
    public void Run()
    {
        string[] names = ["Lexa", "Ada", "Skorin"];

        for (int i = 0; i < names.Length; i++)
        {
            foreach (string name in names)
            {
                Console.Write(name);
            }
            Console.WriteLine();
            string firstName = names[0];
            names = names[1..];
            string[] newNames = [.. names, firstName];
            names = newNames;
        }
    }
}