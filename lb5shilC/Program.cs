Console.WriteLine("Введите сумму вклада ");
double a = Convert.ToDouble(Console.ReadLine());
if( a < 100)
{
    a *= 1.05;
    Console.WriteLine("Вы получите {0} ",a);
}
if (a > 100 && a < 200)
{
    a *= 1.07;
    Console.WriteLine("Вы получите {0} ", a);
}
if( a > 200 )
{
    a *= 1.1;
    Console.WriteLine("Вы получите {0} ", a);
}