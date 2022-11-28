// Написать программу, которая 
// из имеющегося массива строк формирует массив из строк, длина которых либо меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// пример:
// ["hello", "2", "world", ":)"] -> ["2", ":)"]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

void ArrayStrings(string[] arrayStrings)
{

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        arrayStrings[i] = element;
    }
}

void ThreeCharactersArray(string[] arrayStrings, string[] arrayFinal)
{

    int itemSize = 3;
    int count = 0;

    for (int j = 0; j < size; j++)
    {
        if (arrayStrings[j].Length <= itemSize)
        {
            arrayFinal[count] = arrayStrings[j];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
string[] arrayStrings = new string[size];
ArrayStrings(arrayStrings);

string[] arrayFinal = new string[size];
ThreeCharactersArray(arrayStrings, arrayFinal);

PrintArray(arrayStrings);
Console.Write($"=> ");
PrintArray(arrayFinal);
