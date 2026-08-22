//Exceptions = Errors that occur during execution 

int x = 0;
int y = 0;
double result;
calculator();
void calculator()
{
    bool state;
    String? decision = "";
    do
    {
        try //tries the code
        {
            Console.WriteLine("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            result = x / y;

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
        catch/*catches the code*/(FormatException a)
        {
            Console.WriteLine("ENTER ONLY NUMBER");
            Console.WriteLine(a); //outputs the problem
        }
        catch (DivideByZeroException b)
        {
            Console.WriteLine("CANNOT DIVIDE WITH ZERO");
            Console.WriteLine(b);
        }
        catch (Exception c)//Incase the user did the impossible
        {
            Console.WriteLine("WTF IS THAT?");
            Console.WriteLine(c);
        }
        finally //after 
        {
            Console.WriteLine("Thanks for ruining me");
        }
        Console.Write("Try Again? ");
        decision = Console.ReadLine();
        if (decision == "Y" || decision == "y")
        {
            Console.Clear();
            state = true;
            calculator();
        }
        else
        {
            state = false;
        }
    } while (state);
}
