int x = new Random().Next(20, 100);
int x1, x2;
x1 = x / 10;
x2 = x % 10;
Console.WriteLine(x);
if (x1 >= x2)
Console.WriteLine(x1);
else
Console.WriteLine(x2);


