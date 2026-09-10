public class TheDominionOfKings : SmallExcercise
{
    public void Run()
    {
        int estates, dutchies, provinces, total;
        Console.WriteLine("Please input the amount of Estates you own: ");
        estates = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input the amount of Dutchies you own: ");
        dutchies = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input the amount of Provinces you own: ");
        provinces = int.Parse(Console.ReadLine());

        total = estates + (dutchies * 3) + (provinces * 6);

        Console.WriteLine("Your total worth is: " + total);
    }
}
