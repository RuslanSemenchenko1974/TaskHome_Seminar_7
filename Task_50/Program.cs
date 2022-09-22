// Задача 50: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Метод задает массив случайных вещественных чисел
double[,] ArrayOfRandomNambers(int n,int m)

{
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
return array;
}
// метод считывает с консоли число тип int
int ReadNamberInt()
{
    int a=0;
    bool parsNIsOk=false;
    while (!parsNIsOk)
    {
        
        parsNIsOk=int.TryParse(Console.ReadLine(), out int numberN);
        if(!parsNIsOk)
        {
            Console.WriteLine("Введено неверно, введите заново:");
        }
        else a=numberN;
    }
    return a;
}


Console.Clear();
int n=0;
int m=0;
Console.Write("Введите количество строк :");
n=ReadNamberInt();
Console.Write("Введите количество столбцов :");
m=ReadNamberInt();
double [,] array= ArrayOfRandomNambers(n,m);
Console.Write("Введите индекс строки элемента массива :");
int i=ReadNamberInt();
Console.Write("Введите индекс столбеца элемента массива :");
int j=ReadNamberInt();


 if ((i>array.GetLength(0))^(j>array.GetLength(1)))
 Console.WriteLine("Элемента не существует");
 else 
 Console.WriteLine($"Элемент массива с индексом [{i},{j}]= [{String.Format("{0:0.000}", array[i,j])}]");