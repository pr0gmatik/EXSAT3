//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Найдем растояние между точками в 3D пространстве");

Console.WriteLine("Укажите первую координату Х в точке А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите вторую координату Y в точке А");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите третью координату Z в точке А");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите первую координату Х в точке B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите вторую координату Y в точке B");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите третью координату Z в точке D");
int z2 = Convert.ToInt32(Console.ReadLine());

double num = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
double num1 = Math.Round(num,2); 
Console.WriteLine("Расстояние между координатами в 3D пространстве равно " + num1);