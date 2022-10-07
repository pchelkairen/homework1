int number = new Random () .Next (99, 1000);
Console.WriteLine (number);

int a = (number % 100 - number % 10) / 10;
Console.WriteLine ("Вторая цифра трёхзначного числа: ");
Console. Write (a);