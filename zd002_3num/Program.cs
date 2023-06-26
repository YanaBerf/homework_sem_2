Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.Write("третьего числа не существует");
}

int thirdnum(int num){
while (num > 999){
    num /= 10;
}
return num % 10;
}
Console.WriteLine(thirdnum(num));


