


Animal Dog = new Animal("Browny", 5, "Brown");

Console.WriteLine(Dog.ToString());
Console.WriteLine(Dog);


 class Animal
{
    String name;
    int age;
    String color;
    public Animal(String name, int age, String color){
        this.name = name;
        this.age = age;
        this.color = color;
    }

    public virtual void Speak()
    {
        Console.WriteLine("Speak");
    }
    public override string ToString()
    {
        String message = $"This is {name}, he is {age} years old and he is color {color}";
        return message;

        //or
        // return $"This is {name}, he is {age} years old and he is color {color}";
    }
}
