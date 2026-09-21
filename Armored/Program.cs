Console.WriteLine("Leather Armor");
Puppet puppetLeather = new(new Armor(ArmorTypes.Leather));
for (int i = 0; i < 10; i++)
{
    puppetLeather.DealDamage(4);
    Console.WriteLine(puppetLeather.HP);
}

Console.WriteLine("\nIron Armor");
Puppet puppetIron = new(new Armor(ArmorTypes.Iron));
for (int i = 0; i < 10; i++)
{
    puppetIron.DealDamage(4);
    Console.WriteLine(puppetIron.HP);
}

Console.WriteLine("\nDragon Scale Armor");
Puppet puppetDragon = new(new Armor(ArmorTypes.DragonScale));
for (int i = 0; i < 10; i++)
{
    puppetDragon.DealDamage(4);
    Console.WriteLine(puppetDragon.HP);
}

Console.ReadKey();
public class Puppet(Armor armor)
{
    public int HP { get; private set; } = 20;
    private Armor Armor { get; } = armor;

    public void DealDamage(int amount)
    {
        amount = Armor.ReduceDamage(amount);
        HP -= amount;
        if (HP < 0) HP = 0;
    }
}

public class Armor(ArmorTypes armorType)
{
    private int Durability { get; set; } = 5;
    private ArmorTypes ArmorType { get; } = armorType;

    public int ReduceDamage(int initialAmount)
    {
        float damageReduction = ArmorType switch
        {
            ArmorTypes.Leather => 0.75f,
            ArmorTypes.Iron => 0.5f,
            ArmorTypes.DragonScale => 0.2f
        };
        if (initialAmount > 0 && Durability > 0)
        {
            int reducedAmount = (int)(initialAmount * damageReduction);
            Durability--;
            return reducedAmount;
        }
        return initialAmount;
    }
}

public enum ArmorTypes { Leather, Iron, DragonScale }