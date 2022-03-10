// Напишите программу, которая принимает на вход координаты двух точек и находит растояние между ними в 3D пространстве.

double Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    double Value = double.Parse(strValue);
    return Value;
}

double x1 = Promt("Введите x1 первой точки: ");
double y1 = Promt("Введите y1 первой точки: ");
double c1 = Promt("Введите c1 первой точки: ");
double x2 = Promt("Введите x2 первой точки: ");
double y2 = Promt("Введите y2 первой точки: ");
double c2 = Promt("Введите c2 первой точки: ");
double x3 = x2-x1;
double y3 = y2-y1;
double c3 = c2-c1;

double d = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(c3, 2));
Console.Write(d);
