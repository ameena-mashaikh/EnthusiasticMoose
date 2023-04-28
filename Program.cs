//*Rock Paper Scissors

//Need a Scoreboard for computer and player, I think I need two count variables (one for the user and one for the computer) to track the score
//Need to write options for the user to pick (Rock, Paper, Scissors), also add failsafe in case they don't pick 1, 2, or 3
//Add the ASCII hand symbols to correspond with what was picked

using System;
//Main();

int player = 0;
int computer = 0;

while (true)
{
    ScoreBoard();

}
void ScoreBoard()
{
    Console.WriteLine($@"
        -------------------------------------------------
        |  Player: {player}   |  Computer: {computer}   |
        -------------------------------------------------
    
    ");
    Console.WriteLine(@"
    What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors 
    ");
    Answer();

}




void Answer()
{
    string userAnswer = Console.ReadLine();
    Random randNum = new Random();
    int computerAnswer = randNum.Next(0, 4);
    int parseAnswer = Int32.Parse(userAnswer);

    string paper = @"
      _______
    ---' ____)____
            ______)
            _______)
            _______)
    ---.__________)
    ";

    string rock = @"
        _______
    ---'   ____)
            (_____)
            (_____)
            (____)
    ---.__(___)
    ";


    string scissors = @"
        _______
    ---'   ____)____
                ______)
            __________)
            (____)
    ---.__(___)
    
    ";

    while (userAnswer != "3" && userAnswer != "2" && userAnswer != "1")
    {
        Console.Write($"Invalid answer. Please input 1, 2, or 3");
        userAnswer = Console.ReadLine();
    };

    if (parseAnswer == 1 && computerAnswer == 2)
    {
        Console.WriteLine($@"
            {rock}

            VS

            {paper}
        "
        );
        computer += 1;
    }

    else if (parseAnswer == 1 && computerAnswer == 3)
    {
        Console.WriteLine($@"
            {rock}

            VS

            {scissors}
        "
        );
        player++;
    }

    else if (parseAnswer == 2 && computerAnswer == 1)
    {
        Console.WriteLine($@"
            {paper}

            VS

            {rock}
        "
        );
        player++;
    }

    else if (parseAnswer == 2 && computerAnswer == 3)
    {
        Console.WriteLine($@"
            {paper}

            VS

            {scissors}
        "
        );
        computer++;
    }

    else if (parseAnswer == 3 && computerAnswer == 2)
    {
        Console.WriteLine($@"
            {scissors}

            VS

            {paper}
        "
        );
        player++;
    }


    else if (parseAnswer == 3 && computerAnswer == 1)
    {
        Console.WriteLine($@"
            {scissors}

            VS

            {rock}
        "
        );
        computer++;
    }

    else if (parseAnswer == computerAnswer)
    {
        if (parseAnswer == 1)
        {
            Console.WriteLine($@"
            {rock}

            VS

            {rock}
        ");
            player += 0;
        }

        else if (parseAnswer == 2)
        {
            Console.WriteLine($@"
            {paper}

            VS

            {paper}
        "
        );
            player += 0;
        }
        else if (parseAnswer == 3)
        {
            Console.WriteLine($@"
            {scissors}

            VS

            {scissors}
        "
        );
            player += 0;
        }

    }


}