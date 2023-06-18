// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int startNum = Convert.ToInt32(Console.ReadLine());

int stopNum = 1;

System.Console.WriteLine(PrintNumbers(startNum, stopNum));

string PrintNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        return num1.ToString();
    }
    return (num1 + " " + PrintNumbers(num1 - 1, num2));
}