public class FarmFields : SmallExcercise
{
    public void Run()
    {
        int length, width;
        Console.WriteLine("Please input the field length: ");
        length = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input the field width: ");
        width = int.Parse(Console.ReadLine());

        Console.WriteLine("The area of the field is: " + length * width);
    }
}