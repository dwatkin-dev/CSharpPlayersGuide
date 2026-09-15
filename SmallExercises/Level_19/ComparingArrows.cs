public class ComparingArrows : SmallExcercise
{
    // Arrow class and associated enums are in VinFletchersArrows.cs

    public void Run()
    {
        Arrow arrowOne = new();
        Arrow arrowTwo = new();
        Arrow arrowThree = new();

        arrowOne.Weight = 30;
        arrowTwo.Weight = 35;
        arrowThree.Weight = 45;

        arrowOne.Arrowhead = ArrowheadShape.Blunt;
        arrowTwo.Arrowhead = ArrowheadShape.Field;
        arrowThree.Arrowhead = ArrowheadShape.Broadhead;

        arrowOne.Fletching = FletchingType.TurkeyFeathers;
        arrowTwo.Fletching = FletchingType.GooseFeathers;
        arrowThree.Fletching = FletchingType.GooseFeathers;

        arrowOne.PrintArrow();
        Console.WriteLine();
        arrowTwo.PrintArrow();
        Console.WriteLine();
        arrowThree.PrintArrow();
    }
}