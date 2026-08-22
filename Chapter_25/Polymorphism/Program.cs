//Polymorphism = Having many forms
//similarities

Human human = new Human();
Dog dog = new Dog();
Cheetah cheetah = new Cheetah();

Creature[] creatures = { human, dog, cheetah };

foreach (Creature racer in creatures)
{
    racer.Go();
}
class Creature
{
    public virtual void Go()
    {

    }
}
class Human : Creature
{
    public override void Go()
    {
        Console.WriteLine("Fast");
    }
}
class Dog : Creature
{
    public override void Go()
    {
        Console.WriteLine("Faster");
    }
}
class Cheetah : Creature
{
    public override void Go()
    {
        Console.WriteLine("Fastest");
    }
}