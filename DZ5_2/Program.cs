// Написать программу копирования массива
void PrintArrey(int[] a)
{
    for (int j=0; j<a.Length; j++)
    {
    Console.Write(a[j]+ " ");
    }
}
void CopyArrey(int [] a, int [] b)
{
    for (int j=0; j<a.Length; j++)
    {
    b[j] = a[j];
    }
}

Console.WriteLine("введите размер массива:");
int l=int.Parse(Console.ReadLine() ?? "0");
int [] arrey = new int[l];
int [] arrey_copy = new int[l];
for(int i=0; i<arrey.Length; i++)
{
    arrey [i] = new Random().Next(-10, 10);
}
Console.WriteLine("Получился массив:");
PrintArrey(arrey);
Console.WriteLine(" ");
CopyArrey(arrey, arrey_copy);
Console.WriteLine("Скопированный массив:");
PrintArrey(arrey_copy);