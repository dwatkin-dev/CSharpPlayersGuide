public class ConstructingArrowsFast : SmallExcercise
{
    // Arrow class and associated enums are in VinFletchersArrows.cs
    public void Run()
    {
        Arrow arrowOne = new(30, ArrowheadShape.Blunt, FletchingType.TurkeyFeathers);
        Arrow arrowTwo = new(35, ArrowheadShape.Field, FletchingType.GooseFeathers);
        Arrow arrowThree = new(45, ArrowheadShape.Broadhead, FletchingType.GooseFeathers);

        arrowOne.PrintArrow();
        Console.WriteLine();
        arrowTwo.PrintArrow();
        Console.WriteLine();
        arrowThree.PrintArrow();
    }
}