// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] threeCharArray(string[] array)
{
    string[] threeCharArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int index = 0;
        if (array[i].Length <= 3)
        {
            threeCharArray[index] = array[i];
            index++;
        }
    }
    return threeCharArray;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != "") System.Console.WriteLine(array[i]);
    }
}

string[] array = new string[] { "asdf", "qwer", "u", "hj", "tyui", "wq", "123", "12345" };
printArray(threeCharArray(array));