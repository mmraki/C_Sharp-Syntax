using System.ComponentModel.DataAnnotations;

int[] nt = { 1, 2, 3, 4, 5 };
double[] le = { 1.0, 2.0, 3.0, 4.0, 5.0 };
String[] ng = { "1", "2", "3", "4", "5" };

ShowElements(nt);
ShowElements(le);
ShowElements(ng);

static void ShowElements<Thing>(Thing[] array)
{
    foreach(Thing item in array)
    {
        Console.WriteLine($"Item: {item}");
    }
    Console.WriteLine();
}