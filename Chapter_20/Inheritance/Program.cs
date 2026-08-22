//Inheritance = We can reuse a class fields and methods  

Sport sport = new Sport();
sport.Score();
sport.total();


Basketball basketball = new Basketball();
basketball.Score();
Console.WriteLine($"Number of players: {basketball.player}");
basketball.total();
Console.WriteLine(Basketball.score);

Volleyball volleyball = new Volleyball();
volleyball.Score();
Console.WriteLine($"Number of players: {volleyball.player}");
volleyball.total();

//Abstract Classes indicates incomplete implementations or missing components
class Sport     //Parent Class
{
    public static int score = 0;

    public void Score()
    {
        Console.WriteLine("Yoou have gained a point");
        score++;
    }
    public void total()
    {
        Console.WriteLine($"Total Score: " + score);
    }
}
class Basketball : Sport        //Child Class
{
    public int player = 5;
}
class Volleyball : Sport        //Child Class
{
    public int player = 6;
}

    /*The Child Class has acces to all the member fields and methods*/

