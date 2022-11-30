// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 99)
{
    Console.WriteLine("Заданное число не является трехзначным, третьей цифры нет.");
}
else
{
    char [] array = num.ToString().ToCharArray();
    Console.WriteLine($"Третья цифра заданного числа {array[2]}. ");
}

 

