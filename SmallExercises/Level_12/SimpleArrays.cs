public class SimpleArrays : SmallExcercise
{
    public void Run()
    {
        int[] myArray = [1, 2, 3, 4, 5];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}