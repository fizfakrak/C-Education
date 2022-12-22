Console.Clear();
Console.WriteLine("Введите сторону квадратного массива");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
int[,] matrix_1 = new int[a,a];
int row = 0, column = 0;
int row_res = 0, column_res = 0;
Console.WriteLine("Исходный массив 1");
for(row = 0; row<a; row++)
{
    for(column = 0; column<a;column++)
    {
        matrix_1[row,column] = new Random().Next(0,10);
        Console.Write($"{matrix_1[row,column]}    ");
    }
   Console.WriteLine(); 
}
