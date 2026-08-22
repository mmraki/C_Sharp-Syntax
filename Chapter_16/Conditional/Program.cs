//Conditional Operator = Shortened if else
double temp;
String message;
Console.WriteLine("Enter Temperature: ");
temp = Convert.ToDouble(Console.ReadLine());
/*
if (temp <= 50){
    message = "Its Cold";
}else{
    message = "Its Hot";
}
*/
message = (temp <= 50) ? "Its Fuckin Cold": "Its Fuckin Hot";
Console.WriteLine(message);

Console.WriteLine((temp <= 50) ? "Its Fuckin Cold" : "Its Fuckin Hot");