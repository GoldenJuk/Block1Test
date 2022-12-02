/*
    Программа, которая из имеющегося массива строк
    формирует массив из строк, длина которых <= 3 символам.
    Первоначальный массив вводится с клавиатуры пользователем.
*/

Console.Clear();
string[] GetArrayWordsThreeCharacters(string[] array)
{
    int j = 0;
    string[] temparray = new string[array.Length]; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i] != string.Empty)
        {
        temparray[j] = array[i];
        j++;
        }
    }
//Формируем массив необходимого размера

    string[] resultarray = new string[j]; 
    
    for (int i = 0; i < j; i++) resultarray[i] = temparray[i];
    return resultarray;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    if (array.Length > 1)
    {
        for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

Console.WriteLine("Введите набор слов разной длины. Для разделения используйте один пробел");
Console.WriteLine("Когда захотите остановиться, нажмите Enter");
Console.WriteLine();
string[] result = GetArrayWordsThreeCharacters(Console.ReadLine().Split(" "));
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых <= 3 символам:");
Console.WriteLine();
PrintArray(result);

Console.ReadKey();