# Описание решения контрольной работы

## ***Задание*** 
![](Test.jpg)
 
  ---

### **Алгоритм решения задачи**

1. Просим пользователя ввести с клавиатуры набор слов разной длины.
0. Заносим все, что ввел пользователь в массив типа string.
0. Создаем метод для решения задачи в котором делаем следующие шаги:

    a. Вводим переменную для счетчика и присваиваем ей нулевое значение. Эта переменная нужна будет для определения длины результирующего массива. Создаем цикл - для прохождения по всем элементам входного массива строк;

    b. Следующим шагом будет проверка: если количество символов в искомой строке меньше или равно 3, то заносим эту строку в новый массив. И одновременно увеличиваем счетчик на 1;

    c. В итоге получится новый массив, размером с исходный, в котором скорее всего будут присутствовать нулевые(пустые строки) значения;

    d. Для формирования результирующего массива необходимой длины, создаем цикл, в котором будем присваивать результирующему массиву значения из пункта "c". Цикл ограничим значением счетчика, полученным в пункте "c".

0. Выводим на экран результирующий массив.
---

### **Исходный код**

```
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