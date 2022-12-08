Console.Clear();
Console.Write("Введитее размер массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = new int[lenght];
for(int counter = 0; counter<array.Length; counter++)
{
    Console.WriteLine("Введитее элемент массива: ");
    array[counter] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");