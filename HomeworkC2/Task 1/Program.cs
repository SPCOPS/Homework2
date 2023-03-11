Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while( n < 100 || n >= 1000)
{
    Console.Write("Вы ошиблись!\nВведите трёхзначное число: ");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n1 * 10 + n3);