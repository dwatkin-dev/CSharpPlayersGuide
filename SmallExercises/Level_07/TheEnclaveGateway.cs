public class TheEnclaveGateway : SmallExcercise
{
    // All parts combined to one program
    public void Run()
    {
        Console.WriteLine("Please enter your three symbols:");
        string input = Console.ReadLine();

        if(input.Length == 3)
        {
            int secretNumber = 0;
            string passphrase = "";
            if (input[0] == '#')
            {
                secretNumber += 4;
                passphrase += "dah";
            }
            else if (input[0] == 'o')
            {
                secretNumber += -3;
                passphrase += "fus";
            }
            else if (input[0] == '^')
            {
                secretNumber += -2;
                passphrase += "ro";
            }
            else if (input[0] == 'x')
            {
                secretNumber += 1;
                passphrase += "bex";
            }
            else
            {
                passphrase += "?";
            }

            if (input[1] == '#')
            {
                secretNumber += 4;
                passphrase += "dah";
            }
            else if (input[1] == 'o')
            {
                secretNumber += -3;
                passphrase += "fus";
            }
            else if (input[1] == '^')
            {
                secretNumber += -2;
                passphrase += "ro";
            }
            else if (input[1] == 'x')
            {
                secretNumber += 1;
                passphrase += "bex";
            }
            else
            {
                passphrase += "?";
            }

            if (input[2] == '#')
            {
                secretNumber += 4;
                passphrase += "dah";
            }
            else if (input[2] == 'o')
            {
                secretNumber += -3;
                passphrase += "fus";
            }
            else if (input[2] == '^')
            {
                secretNumber += -2;
                passphrase += "ro";
            }
            else if (input[2] == 'x')
            {
                secretNumber += 1;
                passphrase += "bex";
            }
            else
            {
                passphrase += "?";
            }

            Console.WriteLine("The secret number is " + secretNumber);
            Console.WriteLine("The passphrase is: " + passphrase);
        }
    }
}