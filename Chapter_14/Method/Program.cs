using System.Reflection;
String name = "Meraki"; //<--------------------------------------
int age = 20;           //<--------------------------------------
int money = 0;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
void greetings(String name, int age)//Parameters = Requirements
{
    Console.WriteLine($"Good evening, {name}");
    Console.WriteLine($"{name} is {age} years old");
    Console.WriteLine($"{name} has a balance of {money} in his bank account so {name} is broke asf\n");
}

greetings(name, age); //Arguments = Actual Value 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////


helloWorld();

void helloWorld(){

    Console.WriteLine("\nHello, World\n");
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
int fibonacci(int n)
{
    if (n <= 1) return n;
    else return fibonacci(n - 1) + fibonacci(n - 2);

}

int result = fibonacci(5);
Console.WriteLine($"The fibonacci number is {result}");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////    
int multiply(params int[] x)
    {
    int total = 1;

        foreach (int price in x)
        {
        total *= price;
        }
    return total;
    }

    //Method Overload
   


Console.WriteLine("The answer is: " + multiply(6, 7, 8, 9));
Console.WriteLine(multiply(result, result, result, result));
