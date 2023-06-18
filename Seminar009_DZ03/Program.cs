// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число = ");
int fistrNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число = ");
int lastNum = Convert.ToInt32(Console.ReadLine());

Console.Write(Akkerman(fistrNum, lastNum));

int Akkerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0 && num1 > 0)
    {
        return Akkerman(num1 - 1, 1);
    }
    else
    {
        return (Akkerman(num1 - 1, Akkerman(num1, num2 - 1)));
    }
}