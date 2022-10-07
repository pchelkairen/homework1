int number = new Random () .Next (10, 99);
Console.WriteLine (number);

int a = number % 10;
int b = (number % 100 - number % 10) / 10;

if (a > b)
{
 Console.WriteLine ("Наибольшая цифра числа: ");
 Console. Write (a);   
}

else
{
 Console.WriteLine ("Наибольшая цифра числа: ");
 Console. Write (b);   
}
