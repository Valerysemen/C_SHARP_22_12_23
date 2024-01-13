// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Введём координату точки по оси (X): ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введём координату точки по оси (Y): ");
int y = int.Parse(Console.ReadLine());

if ((x > 0) && (y > 0))
    Console.WriteLine("Точка в 1ой четверти");
else if ((x > 0) && (y < 0))
    Console.WriteLine("Точка во 2ой четверти");
else if ((x < 0) && (y < 0))
    Console.WriteLine("Точка в 3ей четверти");
else if ((x < 0) && (y > 0))
    Console.WriteLine("Точка в 4ой четверти");
else if ((x == 0) && (y == 0))
    Console.Write("Точка в центре координат");
else
    Console.Write("Точка лежит на одной из осей");