Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100)
Console.WriteLine("Третьей цифры нет");
while (n > 999)
{
   n = n /= 10;
}
n = n % 10;
Console.WriteLine(n);