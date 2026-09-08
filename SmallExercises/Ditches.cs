public class Ditches : SmallExcercise
{
    public void Run()
    {
        int length, width, t1, t2;
        Console.WriteLine("Please input the field length: ");
        length = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input the field width: ");
        width = int.Parse(Console.ReadLine());

        t1 = width + length / 2 * width;
        t2 = length + width / 2 * length;

        Console.WriteLine("T1: " + t1);
        Console.WriteLine("T2: " + t2);
    }
}
