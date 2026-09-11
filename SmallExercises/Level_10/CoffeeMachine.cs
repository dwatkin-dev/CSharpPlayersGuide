public class CoffeeMachine : SmallExcercise
{
    public void Run()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int time = 4;
        int sugar = 1;
        int cream = 3;

        string italics = "\e[3m";
        string italicsOff = "\e[23m";
        string coffeeFG = "\e[38;2;240;227;144m";
        string fGOff = "\e[39m";
        string coffeeBG = $"\e[48;2;{75 + 30 + cream};{54 + 23 * cream};{33 + 19 * cream}m";
        string bGOff = "\e[49m";
        string coffee = $"{coffeeFG}{coffeeBG}☕{italics}coffee{bGOff}{fGOff}{italicsOff}";



        Thread.Sleep(time * 1000);
        // ...
        Console.WriteLine($"The {coffee} is ready!");
    }
}