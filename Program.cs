// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] array1 = new string[4]{"Hello", "2", "world", ":-)"};
// string[] array1 = new string[4]{"1234", "1567", "-2", "computer science"};
// string[] array1 = new string[3]{"Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];
Array3ElFind(array1,array2);
PrintArray(array1);
Console.Write(" -> ");
PrintArray(array2);


void Array3ElFind(string[] array1, string[] array2) //поиск строки из 3х эл-тов
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array) //печать массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write(" ]");
}
