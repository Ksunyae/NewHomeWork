int a;
Console.WriteLine("Введите любое число:");
a = Convert.ToInt32(Console.ReadLine());
if (a < 99);
{
    Console.WriteLine("Третьей цыфры нет");
    Console.WriteLine("Введите любое число:");
    a = Convert.ToInt32(Console.ReadLine());
}
Console.Write(Convert.ToString(a)[2]);