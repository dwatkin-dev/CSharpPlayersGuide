public class LongArrays : SmallExcercise
{
    public void Run()
    {
        int elements = 100;
        int[] myArray = new int[elements];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i + 1;
        }
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}
