Console.Clear();
Console.Write("Введите день недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7) // || - или(or) дизъюнкция
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = int.Parse(Console.ReadLine()!);
}
if (n < 6)
    Console.WriteLine("Нет");
else
    Console.WriteLine("Да");