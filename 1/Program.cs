Console.Clear();
Console.Write("Ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Введите 5-значное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int i = 0;
int m = n;
while (m > 0)
{
    int q = m % 10;
    i = i * 10 + q;
    m = (m - q) / 10;
}
if (n == i)
{
    Console.Write("Это палиндром");
} 
else
    Console.Write("Это не палиндром");
