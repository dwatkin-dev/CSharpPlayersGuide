Arrow[] arrows = new Arrow[30];

for (int i = 0; i < arrows.Length; i++)
{
    if (i < 10) arrows[i] = Arrow.CreatePracticeArrow();
    else if (i < 20) arrows[i] = Arrow.CreateMarksmanArrow();
    else arrows[i] = Arrow.CreateEliteArrow();
}

foreach (var arrow in arrows)
{
    Console.WriteLine(arrow.Arrowhead);
}

Console.ReadKey();

public class Arrow
{
    public ArrowheadShape Arrowhead { get; }
    public FletchingType Fletching { get; }
    public float Weight { get; }

    public Arrow(ArrowheadShape arrowhead, FletchingType fletching, float weight)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Weight = weight;
    }

    public static Arrow CreatePracticeArrow() => new Arrow(ArrowheadShape.Blunt, FletchingType.Turkey, 30);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowheadShape.Field, FletchingType.Goose, 35);
    public static Arrow CreateEliteArrow() => new Arrow(ArrowheadShape.Broadhead, FletchingType.Goose, 45);

    private float GetDamage()
    {
        float damage;

        damage = Arrowhead switch
        {
            ArrowheadShape.Broadhead => 8,
            ArrowheadShape.Field => 5,
            ArrowheadShape.Blunt => 3,
            _ => 0
        };

        damage += Fletching switch
        {
            FletchingType.Goose => 0,
            FletchingType.Turkey => -1,
            FletchingType.Chicken => -2,
            _ => 0
        };

        return damage * (Weight / 50);
    }

    public void DisplayArrow()
    {
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Shape: {Arrowhead} Tip");
        Console.WriteLine($"Fletching: {Fletching} Feathers");
        Console.WriteLine($"Damage: {GetDamage()}");
        Console.WriteLine();
    }
}

public enum ArrowheadShape { Broadhead, Field, Blunt }
public enum FletchingType { Goose, Turkey, Chicken }