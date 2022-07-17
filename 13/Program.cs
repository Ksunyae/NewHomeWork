Console.WriteLine("Введите любую цифру обозначающую день недели:");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("Ты ошибся");
    a = Convert.ToInt32(Console.ReadLine());
}

if (a == 6 || a == 7)
{
    Console.WriteLine("Этот день является выходным");
}

else
{
    Console.WriteLine("Этот день будний");
}