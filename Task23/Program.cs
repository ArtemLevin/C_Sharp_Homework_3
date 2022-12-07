// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27

// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"{N} -> ");

int counter = 1; 
double cube;

while (counter < (N + 1))
{
    cube = Math.Pow (counter, 3);
    if (counter == N)
    {
        Console.Write($"{cube}"); // исключаем запятую после последнего куба
        counter++;
    }
    else
    {
        Console.Write($"{cube}, ");
        counter++;
    }
}