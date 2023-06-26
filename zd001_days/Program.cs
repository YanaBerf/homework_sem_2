Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else if (day >= 1 && day <= 5)
{
        Console.WriteLine("будний день");
}
else
{
    Console.WriteLine("такого дня недели не существует");
}