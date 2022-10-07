int a = 3;
int b = 5;
int c = 0;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write ("max = ");
Console.WriteLine (max);
