// Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

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

// Метод Находит среднее арифметическое элементов в каждом столбце
void FindArithmeticMean(int[,] array)
{
    double arithmeticMean=0;
    int n=array.GetLength(0);
    int m=array.GetLength(1);

for (int j=0; j<m; j++)
{
    arithmeticMean=0;
    for(int i=0; i<n; i++)
    {
        arithmeticMean=(array[i,j]+arithmeticMean);
    }
    Console.Write($"[{String.Format("{0:0.000}", arithmeticMean/n)}] ");
}
    
}

int n=0;
int m=0;
Console.Clear();

Console.Write("Введите количество строк :");
 n=ReadNamberInt();
Console.Write("Введите количество столбцов :");
 m=ReadNamberInt();
// Задаем массив случайных чисел
int [,] array= new int[n,m];
for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        array[i,j]=new Random().Next(0,10);
        Console.Write($"[{ array[i,j] }] ");
    }
    Console.WriteLine();
}

Console.WriteLine("среднее арифметическое элементов в каждом столбце :");
FindArithmeticMean(array);