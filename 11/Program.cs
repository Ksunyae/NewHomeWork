int a;
Console.WriteLine("Введите любое трехзначное число:");
a = Convert.ToInt32(Console.ReadLine());
while (a < 100 && a  > 999)
{
    Console.WriteLine("Ты ошибся...");
    a = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(a / 10 % 10);
