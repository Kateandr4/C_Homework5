// Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите b1");
double b1=double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите k1");
double k1=double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b2");
double b2=double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите k2");
double k2=double.Parse(Console.ReadLine() ?? "0");
    double x = (b1-b2)/(k2-k1);
    double y1 = k1*x+b1;
    double y2 = k2*x+b2;
Console.WriteLine( x);
Console.WriteLine( y1);
Console.WriteLine( y2);
   if(y1 == y2 )
    {
        Console.WriteLine("точка пересечения прямых x= "+ x + " y= "+y1);
    }
    else Console.WriteLine("Линии не пересекаются");