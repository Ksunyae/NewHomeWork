int a;
Console.WriteLine("Введите любую цифру обозначающую день недели:");
a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine("Этот день является выходным");
};

if (a < 6)
{
    Console.WriteLine("Это день будний");
};
