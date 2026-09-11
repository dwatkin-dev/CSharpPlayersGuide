public class AnArrayExperiment : SmallExcercise
{
    public void Run()
    {
        int[] myArray = new int[5];
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i+1;
        }
        for (int i = 0; i < myArray.Length; i++) 
        {
            Console.WriteLine(myArray[i]);
        }
    }
}