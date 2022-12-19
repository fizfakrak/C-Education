Console.Clear();
Console.WriteLine("Введите размер массива");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
int[,] matrix = new int[a,b];
double[] av_sum = new double[b];
int row = 0, column = 0;
for(row = 0; row<a; row++)
{
    for(column = 0; column<b;column++)
    {
        matrix[row,column] = new Random().Next();
        Console.Write($"{matrix[row,column] };;");
    }
   Console.WriteLine(); 
}
for(column = 0; column<b; column++)
{
    for(row = 0; row<a;row++)
    {
       av_sum[column] = av_sum[column] + matrix[row,column];
    }
    av_sum[column] = av_sum[column]/a;
}
Console.WriteLine($"[{string.Join(", ", av_sum)}]");
