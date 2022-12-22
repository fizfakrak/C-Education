Console.Clear();
Console.WriteLine("Введите сторону квадратного массива");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
int[,] matrix_1 = new int[a,a];
int[,] matrix_2 = new int[a,a];
int[,] matrix_res = new int[a,a];
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
Console.WriteLine("Исходный массив 2");
for(row = 0; row<a; row++)
{
    for(column = 0; column<a;column++)
    {
        matrix_2[row,column] = new Random().Next(0,10);
        Console.Write($"{matrix_2[row,column]}    ");
    }
   Console.WriteLine(); 
}
Console.WriteLine("Результат умножения матриц");

for(row_res = 0; row_res<a; row_res++)
{
    for(column_res = 0; column_res<a; column_res++)
    {
        for(column = 0; column<a;column++)
        {
            matrix_res[row_res,column_res] = matrix_res[row_res,column_res] + matrix_1[row_res,column]*matrix_2[column,column_res];
            
        } 
        Console.Write($"{matrix_res[row_res,column_res]}    ");           
    }
   Console.WriteLine(); 
}
   
