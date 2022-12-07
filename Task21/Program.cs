// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Вводим координаты точки А");
Console.Write("Введите координату икс: ");
int xA =  int.Parse(Console.ReadLine()!); 
Console.Write("Введите координату игрек: ");
int yA =  int.Parse(Console.ReadLine()!); 
Console.Write("Введите координату зет: ");
int zA =  int.Parse(Console.ReadLine()!); 
Console.WriteLine($"Координаты точки А({xA},{yA},{zA})");

Console.WriteLine("Вводим координаты точки В");
Console.Write("Введите координату икс: ");
int xB =  int.Parse(Console.ReadLine()!); 
Console.Write("Введите координату игрек: ");
int yB =  int.Parse(Console.ReadLine()!); 
Console.Write("Введите координату зет: ");
int zB =  int.Parse(Console.ReadLine()!); 
Console.WriteLine($"Координаты точки В({xB},{yB},{zB})");

double distance = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));

Console.Write("Расстояние меджу точками " + distance );


