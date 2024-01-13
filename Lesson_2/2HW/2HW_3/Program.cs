//Напишите программу, которая принимает на вход целое число
//из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 9) && (num < 100))
{
    if ((num / 10) > (num % 10))
        Console.Write("Наибольшая цифра введённого числа: " + num / 10 + "\n");
    else if ((num / 10) == (num % 10))
        Console.Write("Цифры в числе одинаковые");
    else if ((num / 10) < (num % 10))
        Console.Write("Наибольшая цифра введённого числа: " + num % 10 + "\n");
}
else
    Console.Write("Число вне  диапазона");