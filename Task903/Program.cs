// Задача № 3: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Проверка:
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

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
/// Метод создания функции Аккермана
/// </summary>
/// <param name="firstNumber"> первое число </param>
/// <param name="secondNumber"> второе число </param>
/// <returns></returns>
int Akkerman(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (secondNumber == 0 && firstNumber > 0)
    {
        return Akkerman(firstNumber - 1, 1);
    }
    else
    {
        return (Akkerman(firstNumber - 1, Akkerman(firstNumber, secondNumber - 1)));
    }
}

/// <summary>
/// Метод вызова функции Аккермана
/// </summary>
/// <param name="firstNumber"></param>
/// <param name="secondNumber"></param>
void AkkermanFunction(int firstNumber, int secondNumber)
{
    Console.Write(Akkerman(firstNumber, secondNumber));
}

System.Console.WriteLine("Программа для вычисления функции Аккермана");
System.Console.WriteLine(); // Пустая строка для красоты вывода
int m = InputUser("Введите первое число");
int n = InputUser("Введите второе число");
System.Console.WriteLine(); // Пустая строка для красоты вывода
System.Console.Write("Значение функции Аккермана равно: ");
AkkermanFunction(m, n);