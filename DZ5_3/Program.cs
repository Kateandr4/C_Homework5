// Написать программу масштабирования фигуры
Console.WriteLine("Введите координаты фигуры в формате Х1,Y1 X2,Y2");
string str =  Console.ReadLine();
Console.WriteLine("Введите коэффициент масштабирования k");
double k = double.Parse(Console.ReadLine()?? "0");
string[] points = str.Split(" ");
double[] coord = new double[points.Length * 2];
int index = 0;
for (int i=0; i<points.Length; i++)
{
    string[] chislo = points[i].Split(",");
    coord[index] = int.Parse(chislo[0]);
    ++index;
    coord[index] = int.Parse(chislo[1]);
    ++index;
}

for (int i=0; i<coord.Length; i=i+2)
{
    Console.Write(coord[i]*k+ "," + coord[i+1]*k+ " ");
}

