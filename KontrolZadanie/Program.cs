// Задание:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// метод вывода массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов для ввода: ");
int razmer = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[razmer];
int e = 0;

for (int i = 0; i < razmer; i++)
{
    Console.WriteLine($"Введите элемент № {i + 1}: ");
    string elem = Convert.ToString(Console.ReadLine());

    if (elem.Length <= 3)
    {
        array1[e] = elem;
        e++;
    }
}
Console.WriteLine();
PrintArray(array1);


