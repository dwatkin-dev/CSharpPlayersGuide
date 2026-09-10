public class TheGuidestonePart2 : SmallExcercise
{
    public void Run()
    {
        double x, y, distance;
        Console.WriteLine("Please enter the x co-ordinate distance:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the y co-ordinate distance:");
        y = double.Parse(Console.ReadLine());

        distance = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));

        Console.WriteLine("The distance between the points is: " + distance);
    }
}