int a = new Random () .Next (1, 99999);
Console.WriteLine (a);

int b = 5;
Console.WriteLine (b);

if (a % b == 0)
{
    Console.WriteLine ("Кратно");
}

else
{
    Console.Write ("Не кратно, остаток ");
    int c = a % b;
    Console.Write (c);
}