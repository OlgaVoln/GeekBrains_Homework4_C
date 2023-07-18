// Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int GetInput(string text)
{
    Console.Write(text);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int number = GetInput("Введите число: ");
Console.WriteLine($"Сумма всех чисел в {number} равна {GetSum(number)}");