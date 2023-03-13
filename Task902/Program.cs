// Задача № 2: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//  Проверка:
//  M = 1; N = 15-> 120
//  M = 4; N = 8. -> 30

/// <summary>
/// Метод ввода запрошенного числа от пользователя
/// </summary>
/// <param name="message"> текст сообщения </param>
/// <returns></returns>
int InputUser(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

/// <summary>
/// Метод нахождения суммы чисел в заданном диапазоне
/// </summary>
/// <param name="m"> начало заданного диапазона </param>
/// <param name="n"> конец заданного диапазона </param>
/// <returns></returns>
int SumMN(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumMN(m, n);
        return sum;
    }
}

/// <summary>
/// Метод вызова функции нахождения суммы чисел заданного интервала
/// </summary>
/// <param name="m"> начало заданного диапазона </param>
/// <param name="n"> конец заданного диапазона </param>
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

System.Console.WriteLine("Программа по нахождению суммы натуральных элементов в заданном промежутке");
System.Console.WriteLine(); // Пустая строка для красоты вывода
int m = InputUser("Введите число M");
int n = InputUser("Введите число N");
System.Console.WriteLine(); // Пустая строка для красоты вывода
System.Console.Write("Сумма натуральных элементов в заданном промежутке равна: ");
SumFromMToN(m, n);