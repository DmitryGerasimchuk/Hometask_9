// Задача № 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.

// Проверка:
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

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
/// Метод получения четных чисел в заданном интервале с помощью рекурсии 
/// </summary>
/// <param name="numberM"> начало интервала </param>
/// <param name="numberN"> конец интервала </param>
void GetNaturalEvenNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return;
    if (numberM % 2 == 0) Console.Write($"{numberM}, ");
    GetNaturalEvenNumbers(numberM + 1, numberN);
}

System.Console.WriteLine("Программа по выводу всех чётных натуральных чисел в заданном промежутке");
System.Console.WriteLine(); // Пустая строка для красоты вывода
int numberM = InputUser("Введите число M");
int numberN = InputUser("Введите число N");
System.Console.WriteLine(); // Пустая строка для красоты вывода
System.Console.Write("Чётные натуральные числа в заданном промежутке представляют собой рад: ");
GetNaturalEvenNumbers(numberM, numberN);