public class VinFletchersArrows : SmallExcercise
{
    public void Run()
    {
        Arrow arrow = new();
        arrow.Weight = 35;
        arrow.Arrowhead = ArrowheadShape.Broadhead;
        arrow.Fletching = FletchingType.GooseFeathers;

        arrow.PrintArrow();
    }
}

public class Arrow
{
    public float Weight;
    public ArrowheadShape Arrowhead;
    public FletchingType Fletching;

    public float GetDamage()
    {
        int baseDamage = Arrowhead switch
        {
            ArrowheadShape.Blunt => 3,
            ArrowheadShape.Field => 5,
            ArrowheadShape.Broadhead => 8
        };

        baseDamage += Fletching switch
        {
            FletchingType.GooseFeathers => 0,
            FletchingType.ChickenFeathers => -2,
            FletchingType.TurkeyFeathers => -1,

        };

        return baseDamage * Weight / 50;
    }

    public void PrintArrow()
    {
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Shape: {Arrowhead}");
        Console.WriteLine($"Fletching: {Fletching}");
        Console.WriteLine($"Damage: {GetDamage()}");
    }
}

public enum ArrowheadShape { Broadhead, Field, Blunt }
public enum FletchingType {  GooseFeathers, TurkeyFeathers, ChickenFeathers }