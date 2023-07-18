// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetSum(int number_A, int number_B)
{
    int degree = 1;
    for (int i = 0; i < number_B; i++)
    {
        degree *= number_A;
    }
    return degree;
}

int GetInput(string text)
{
    Console.Write(text);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}

int number_A = GetInput("Введите число А: ");
int number_B = GetInput("Введите число B: ");
Console.WriteLine($"Число {number_A} в степени {number_B} равно {GetSum(number_A, number_B)}");
