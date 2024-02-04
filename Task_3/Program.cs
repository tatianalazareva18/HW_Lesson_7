//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] Array = { 2, 4, 6, 8, 10 };

void OutputInRevers(int[] Array, int i)
{
    Console.WriteLine(Array[i]);

    if (i > 0)
    {
        OutputInRevers(Array, i - 1);

    }
}

Console.WriteLine("Элементы массива в обратном порядке:");

OutputInRevers(Array,Array.Length-1);