
Console.Write("Enter Day: ");
String day = Console.ReadLine();

switch (day){
    case "Monday":
    case "monday":
        Console.WriteLine("Its " + day);
        break;
    case "Tuesday":
    case "tuesday":
        Console.WriteLine("Its " + day);
        break;
    case "Wednesday":
    case "wednesday":
        Console.WriteLine("Its " + day);
        break;
    case "Thursday":
    case "thursday":
        Console.WriteLine("Its " + day);
        break;
    case "Friday":
    case "friday":
        Console.WriteLine("Its " + day);
        break;
    case "Saturday":
    case "saturday":
        Console.WriteLine("Its " + day);
        break;
    case "Sunday":
    case "sunday":
        Console.WriteLine("Its " + day);
        break;
    default:
        Console.WriteLine("Tf?");
        break;
}

/* switch (expression / value){
 *      case _____:
 *          code;
 *          break;
 *      case _____:
 *          code;
 *          break;
 *      default;
 *          code;
 *          break;
 * }
 */