String[,] num = { {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11","12"},  //0
                   {"13","14","15","16","17","18","19","20","21","22","23","24"},   //1
                   {"25","26","27","28","29","30","31","32","33","34","35","36"}    //2
};//                 0    1    2    3    4    5    6    7    8    9    10   11

Console.WriteLine(num[2,11]);

//num[2, 11] = "Placeholder";
//Console.WriteLine(date[x,x]);

foreach (var number in num)
{
    Console.WriteLine(number);
}

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        Console.Write(num[i,j] + "  ");
    }
    Console.WriteLine();
}



















