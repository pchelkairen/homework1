int number = new Random () .Next (100, 999);
Console.WriteLine (number);

int c = number % 10;
int a = (number - number % 100) / 100;

Console.Write (a);   
Console.Write (c);  