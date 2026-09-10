public class TheGuidestonePart1 : SmallExcercise
{
    public void Run()
    {
        double radius, area;
        Console.WriteLine("Please enter the radius of the circle:");
        radius = double.Parse(Console.ReadLine());

        area = Math.PI * (Math.Pow(radius, 2));

        Console.WriteLine("The area of the circle is: " + area);
    }
}
