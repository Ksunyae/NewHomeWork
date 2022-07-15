int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int x1 = x / 100;
int x2 = x % 10;
int result = (x1*10 + x2);
Console.WriteLine(result);



