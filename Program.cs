//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string[] array)
{
    Console.Write("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ThreeChar(string[] array1, string[] array2 )
{
    int element = 0;
    for (int i = 0; i < array1.Length; i++)
    {        
        if (array1[i].Length <= 3 )
        {
            array2[element] = array1[i];
            element++;
        }
    }
}

string[] newArray = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2" };
string[] newArrayTwo = new string[newArray.Length];

PrintArray(newArray);
ThreeChar(newArray,newArrayTwo);
PrintArray(newArrayTwo);
