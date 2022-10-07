int a = new Random () .Next (1, 999);
Console.WriteLine (a);

if (a >= 100)
{
    int b = a % 10;
    Console.Write (" Третья цифра числа ");
    Console.Write (b);
}

else
{ 
    Console.Write ("Третьей цифры числа нет");
}