// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int n=0;
int m=0;
Console.Clear();
Console.Write("Введите количество строк :");
bool parsNIsOk=int.TryParse(Console.ReadLine(), out int numberN);
if(!parsNIsOk)
{
    Console.WriteLine("Введено неверно");
    return;
}
else n=numberN;
Console.Write("Введите количество столбцов :");
bool parsMIsOk=int.TryParse(Console.ReadLine(), out int numberM);
if(!parsMIsOk)
{
    Console.WriteLine("Введено неверно");
    return;
}
else m=numberM;
double [,] array= new double[n,m];
Random rand = new Random(DateTime.Now.Millisecond);
for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        array[i,j]=rand.NextDouble() * 20;                           
        Console.Write($" [{String.Format("{0:0.000}", array[i,j])}] ");
    }
    Console.WriteLine();
}
