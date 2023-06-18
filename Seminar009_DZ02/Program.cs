// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число = ");
int fistrNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число = ");
int lastNum = Convert.ToInt32(Console.ReadLine());

Console.Write(PrintNum(fistrNum, lastNum) + 1);

int PrintNum(int num1, int num2)
{
    int sum = num1;

    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        sum = num1 + PrintNum(num1, num2);
    }
    // Console.Write($" {sum+1}");
    return sum;
}
