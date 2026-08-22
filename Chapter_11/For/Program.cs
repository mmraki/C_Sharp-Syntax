using System.ComponentModel.Design;

for (int i = 0; i < 10; i++){
    Console.WriteLine("Number " + (i + 1));
}
char p = '@';
for (int i = 1; i <= 5; i++)
{
    for(int j = 5; j > i; j--){
        Console.Write (" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write(" " + p);
    }
    Console.Write("\n");
}
Console.WriteLine("Press any key to continue....");
Console.ReadKey();

int rows = 0;
int cols = 0;
char? sym = '*';
int selection = 0;

while (selection != 3)
{
    Console.Clear();
    Console.WriteLine("Menu");
    Console.WriteLine("1. Box Maker");
    Console.WriteLine("2. Show Box");
    Console.WriteLine("3. Quit");
    Console.Write("Selection: ");
    selection = Convert.ToInt32(Console.ReadLine());
    if (selection == 1)
    {
        Console.Clear();
        Console.Write("Enter Number of Rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number of Columns: ");
        cols = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Symbols: ");
        String? character = Console.ReadLine();
        sym = Convert.ToChar(character!);
    }
    else if(selection == 2)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(" " + sym);
            }
            Console.Write("\n");
        }
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Quitting....");
    }


}