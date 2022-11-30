// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Clear();

Console.Write("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной день.");
}
if (num < 6 && num != 0)
{
    Console.WriteLine("Будний день.");
}