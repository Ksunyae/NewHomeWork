Console.Write("Введите число : ");

int a = Convert.ToInt32(Console.ReadLine());
int b = 1;

if (b == 1)
{
    b += 1;
}

while (b <= a);
{
    Console.Write(b+",");
    b += 2;
}