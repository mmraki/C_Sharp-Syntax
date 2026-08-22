using System.ComponentModel.Design;

int selection = 0;
String? name = "";
int? age = 0;
String? gender = "";
String? status = "";


while (selection != 3 )
{
    Console.Clear();
    Console.WriteLine("Menu");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Information");
    Console.WriteLine("3. Quit");
    Console.Write("Selection: ");
    selection = Convert.ToInt32(Console.ReadLine());
    
    if (selection == 1)
    {
        Console.Clear();
        Console.WriteLine("Application Form");
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Gender: ");
        gender = Console.ReadLine();
        Console.Write("Status: ");
        status = Console.ReadLine();
    }
    else if(selection == 2)
    {
        Console.Clear();
        Console.WriteLine("Information Sheet");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Status: " + status);
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine("Quitting...");
    }
}