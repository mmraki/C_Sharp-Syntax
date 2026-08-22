//Random Number
Random random = new Random();


int randnum = random.Next(1, 10 + 1);
int x = random.Next(1, 10+1);
int y = random.Next(1, 10+1);
int z = random.Next(1, 10+1);
//double w = random.NextDouble();
int guess = 0;
bool playAgain = true;
String? selection = "";


Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

//Random Number Guessing Game
while (playAgain)
{
    while (guess != randnum)
    {
        Console.Write("Enter Guess: ");
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess > randnum)
        {
            Console.Clear();
            Console.WriteLine("Guess: " + guess);
            Console.WriteLine("Lower");
        }
        else if (guess < randnum)
        {
            Console.Clear();
            Console.WriteLine("Guess: " + guess);
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine("Random Number: " + randnum);
        }
    }
    Console.Write("Try Again? ");
    selection = Console.ReadLine();

    if (selection == "Y" || selection == "y")
    {
        playAgain = true;
        randnum = random.Next(1, 10+1);
    }
    else
    {
        playAgain = false;
    }


}

Console.WriteLine(random.ToString());