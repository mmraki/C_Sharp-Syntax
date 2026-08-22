using System;
using System.Collections.Generic;
//List = Dynammic data structure to store data similar to array but can increase and decrease accordingly to data
/*
 * 
 * If array appoarch
Food[] food = new Food[2];

Food hotdog = new Food();
Food chesedog = new Food();

food[0] = hotdog;
food[1] = chesedog;
//if food[2] = corndog = error
 */

List<String> food = new List<String>();

food.Add("hotdog");
food.Add("burger");
food.Add("Fries");
food.Add("Chicken");
food.Add("pizza");
food.Add("burger");

//food.Insert(0,"sushi");
//food.Remove("burger");
//food.Sort();
//food.Reverse();
//food.Clear();


String[] foodarray = food.ToArray();
//Console.WriteLine(food[2]);
foreach (String list in food)
{
    Console.WriteLine(list);
}
Console.WriteLine();
//Console.WriteLine(food.Count);
//Console.WriteLine(food.IndexOf("hotdog"));
//Console.WriteLine(food.LastIndexOf("burger"));
//Console.WriteLine(food.Contains("pizza"));

