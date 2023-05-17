// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.Write($"Кубы чисел от 1 до {num}: ");
    for (int i = 1; i <= num; i++)
    {
        if (i == num) Console.Write(Math.Pow(i, 3)); // добавил эту строку ибо бесила запятая в конце списка кубов :)
        else Console.Write($"{Math.Pow(i, 3)}, ");
    }
}
else Console.WriteLine("Число должно быть > 0");