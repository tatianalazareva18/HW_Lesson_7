//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа n и m.

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

int result = ack(n, m);

int ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0)
        {
            return ack(n - 1, 1);
        }
        return ack(n - 1, ack(n, m - 1));

    }
}

Console.WriteLine($"Значение функции Аккермана для n={n} и m={m} равно {result}");
