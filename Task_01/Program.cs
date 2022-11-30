// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 1000 || num <= 99 )
{
    Console.WriteLine("Число не является трехзначным !");
}
else
{
    int res = (num/10)%10;
    Console.WriteLine($"Вторая цифра в числе {num} = {res}");
}







