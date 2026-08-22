
//Method Override = Provides a new version of a method inherited from a parent class
//                  Must be abstract or virtual to be overriden

Dog dog = new Dog();
Cat cat = new Cat();

dog.Speak();
cat.Speak();




class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("HEEELP");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}