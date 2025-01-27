char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int player = 1, turnCount = 0, choice;
bool gameEnd = false;

while (!gameEnd)
{
    Console.Clear();
    Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    do {
        try
        {
            Console.WriteLine("\nPlayer {0}, choose cell from 1 to 9 for step: ", player == 1 ? "X" : "O");
            choice = Convert.ToInt32(Console.ReadLine()) - 1;
        }
        catch (FormatException)
        {
            Console.WriteLine("You entered symbols!");
            choice = -1;
        }
    } while (choice < 0 | choice > 9);
    

    if (board[choice] != 'X' && board[choice] != 'O')
    {
        board[choice] = player == 1 ? 'X' : 'O';
        turnCount++;
    }
    else
    {
        Console.WriteLine("Wrong step, try again.");
        Console.ReadKey();
    }

    // Victory audit
    if ((board[0] == board[1] && board[1] == board[2]) ||
        (board[3] == board[4] && board[4] == board[5]) ||
        (board[6] == board[7] && board[7] == board[8]) ||
        (board[0] == board[3] && board[3] == board[6]) ||
        (board[1] == board[4] && board[4] == board[7]) ||
        (board[2] == board[5] && board[5] == board[8]) ||
        (board[0] == board[4] && board[4] == board[8]) ||
        (board[2] == board[4] && board[4] == board[6]))
    {
        gameEnd = true;
        Console.Clear();
        Console.WriteLine("Player {0} win!", player == 1 ? "X" : "O");
    }
    else if (turnCount == 9)
    {
        gameEnd = true;
        Console.Clear();
        Console.WriteLine("Draw!");
    }

    // Player rotation
    player = player == 1 ? 2 : 1;
}

Console.WriteLine("Finish field:");
Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
Console.WriteLine("---+---+---");
Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
Console.WriteLine("---+---+---");
Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
