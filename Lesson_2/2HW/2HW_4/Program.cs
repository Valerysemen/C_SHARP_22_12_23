//  Напишите программу, которая на вход принимает натуральное число N,
//а на выходе показывает его цифры через запятую.

Console.Write("Ввод натурального числа N ");
int num = int.Parse(Console.ReadLine()!);

string numStr = num.ToString();
for (int i = 0; i < numStr.Length; i++)
{
    Console.Write(numStr[i]);

    if (i < numStr.Length - 1)
    {
        Console.Write(", ");
    }
}