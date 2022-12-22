Console.Clear();
int a = 2;
int[,,] matrix_1 = new int[a,a,a];

int x = 0, y = 0, z = 0;

Console.WriteLine("Исходный кубический массив");
for(x = 0; x<a; x++)
{
    for(y = 0; y<a;y++)
    {   
        for(z = 0; z<a ; z++)
        {
        matrix_1[x,y,z] = new Random().Next(10,100);
        Console.Write($"{matrix_1[x,y,z]}    ");
        }
    }
   Console.WriteLine(); 
}

Console.WriteLine("Результат ");

for(x = 0; x<a; x++)
{
    for(y = 0; y<a;y++)
    {
        for(z = 0; z<a ; z++)
        {
          Console.Write($"{matrix_1[x,y,z]} ({x},{y},{z}) ");
        }
    }
   Console.WriteLine(); 
}        
