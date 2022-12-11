// Написать программу, которая из имеющегося массива строк сформиркет массив из строк, 
//длинна которых меньше,либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться колллекциями,
//лучше обойтись исключительно массивами.


Console.Write("Задайте колличество элементов массива? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
    int len = 3;
    int pos = 0;
    for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= len)
    {
        arrayStrings[pos] = element;
        pos++;
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

PrintArray(arrayStrings);

