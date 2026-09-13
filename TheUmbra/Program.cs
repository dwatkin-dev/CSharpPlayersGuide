int round = 1;
int cityDamage = 0;
int umbraDamage = 0;
int umbraDistance = Random.Shared.Next(25, 75);
int umbraSpeed = Random.Shared.Next(1, 3);
int minDistance = 0;
int maxDistance = 100;
int maxCityDamage = 20;
int maxUmbraDamage = 20;
bool gameOver = false;

while(!gameOver)
{
    int roundDamage = CalculateDamage(round);

    PrintStatus(round, cityDamage, umbraDamage, roundDamage);

    int guess = GetANumber("Enter target range: ");

    if (ValidGuess(minDistance, maxDistance, guess))
    {
        if (guess == umbraDistance)
        {
            Console.WriteLine("That was a direct hit!");
            umbraDamage += roundDamage;
        }
        else if (guess > umbraDistance)
        {
            Console.WriteLine("That went too far!");
        }
        else
        {
            Console.WriteLine("That fell short!");
        }

        round++;
        cityDamage++;
        umbraDistance -= umbraSpeed;

        gameOver = IsGameOver(umbraDistance, cityDamage, umbraDamage, maxCityDamage, maxUmbraDamage);
        if (gameOver)
        {
            PrintStatus(round, cityDamage, umbraDamage, roundDamage);
            AnnounceOutcome(umbraDistance, cityDamage, umbraDamage, maxCityDamage, maxUmbraDamage);
        }

    }
    else
    {
        Console.WriteLine("Invalid input, please enter a range between 0 and 100.");
    }
    Console.WriteLine($"\nPlease press any key to continue.");
    Console.ReadKey();
}

int GetANumber(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

bool ValidGuess(int min, int max, int guess)
{
    return (guess > min && guess <= max);
}

int CalculateDamage(int round)
{
    if (round % 3 == 0 && round % 5 == 0) return 5;
    else if (round % 3 == 0 || round % 5 == 0) return 3;
    else return 1;
}

void PrintStatus(int round, int cityDamage, int umbraDamage, int roundDamage)
{
    Console.Clear();
    Console.WriteLine("--------------- STATUS ---------------");
    Console.WriteLine($"Round: {round}");
    Console.WriteLine($"Structures Destroyed: {cityDamage}");
    Console.WriteLine($"Umbra Damage: {umbraDamage}");
    Console.WriteLine($"A hit will deal {roundDamage} damage right now.");
    Console.WriteLine("--------------------------------------");
}

bool IsGameOver(int umbraDistance, int cityDamage, int umbraDamage, int maxCityDamage, int maxUmbraDamage)
{
    return umbraDistance <=0 || cityDamage >= maxCityDamage || umbraDamage >= maxUmbraDamage;
}

void AnnounceOutcome(int umbraDistance, int cityDamage, int umbraDamage, int maxCityDamage, int maxUmbraDamage)
{
    if (umbraDistance <= 0)
    {
        Console.WriteLine($"\nGame Over! The Umbra reached and killed you then destroyed the city!");
    }
    else if (cityDamage == maxCityDamage)
    {
        Console.WriteLine($"\nGame Over! The Umbra destroyed the city!");
    }
    else if (umbraDamage == maxUmbraDamage)
    {
        Console.WriteLine($"\nCongratulations! You defeated the Umbra!");
    }
}