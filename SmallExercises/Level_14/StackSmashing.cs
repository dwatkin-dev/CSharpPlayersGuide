public class StackSmashing : SmallExcercise
{
    public void Run()
    {
        MethodOne();   
    }

    private void MethodOne()
    {
        MethodTwo();
    }
    private void MethodTwo()
    {
        MethodThree();
    }
    private void MethodThree()
    {
        MethodFour();
    }
    private void MethodFour()
    {
        Console.WriteLine(Environment.StackTrace);
        // int.Parse("a");
    }
}