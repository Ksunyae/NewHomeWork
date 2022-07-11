int a, b, c;
Console.Write("Введите любое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число, отличное от предидуего: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число, отличное от двух предидущих: ");
c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    
}
if(b > a && b > c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
    
}
if(c > b && c > b)
{
    Console.Write("max = ");
    Console.WriteLine(c);
    
}


