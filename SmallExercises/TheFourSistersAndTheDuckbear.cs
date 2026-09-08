public class TheFourSistersAndTheDuckbear : SmallExcercise
{
    public void Run()
    {
        int eggs, sistersEggs, duckbearEggs;
        Console.WriteLine("Please enter how many eggs you have gathered today: ");
        eggs = int.Parse(Console.ReadLine());

        sistersEggs = eggs / 3;
        duckbearEggs = eggs % 3;

        Console.WriteLine("Each sister gets " + sistersEggs + " eggs.");
        Console.WriteLine("The duckbear gets " + duckbearEggs + " eggs.");
    }
}
