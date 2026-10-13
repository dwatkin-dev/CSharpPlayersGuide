/*
 * Player class with a method to chose an specific calss (Quick, Power, Disruption)
 * Duel class knows about two player instances and has a Run method which asks each player to choose attack nd returns duels outcome.
 * History class to keep track of wins and draws.
 * 
 * Run games in indefinate loop recording results. After each round update History and display totals.
 */

while(true)
{
    // Gets the next key pressed by user as a char. The keypress will not be shown in the console
    char letter = Console.ReadKey(true).KeyChar;
    if(letter == 'a') Console.WriteLine(letter);
}

public enum AttackType { Quick, Power, Disruption }