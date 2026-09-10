public class TheTrap : SmallExcercise
{
    public void Run()
    {
        Console.WriteLine("Pebble one size: ");
        int pebbleOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Pebble two size: ");
        int pebbleTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Pebble three size: ");
        int pebbleThree = int.Parse(Console.ReadLine());

        if(pebbleOne == pebbleTwo && pebbleOne == pebbleThree)
        {
            Console.WriteLine("A");
        }
        else if(pebbleOne > 10 || pebbleTwo > 10 || pebbleThree > 10)
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("C");
        }
    }
}