Console.Write("Ввести трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int num2 = (num / 10) % 10;
Console.WriteLine($"{num} -> {num2}");