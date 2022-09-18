/* Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма*/

string[] array = new string[6] { "Kazan", "648", "hello", "%^&", "Rus", "5" };
string[] array2 = new string[array.Length];

void ResultArray(string[] mass, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            mass2[count] = mass[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    Console.WriteLine("Массив строк длина которых меньше, либо равна 3 символа");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
ResultArray(array, array2);
PrintArray(array2);
