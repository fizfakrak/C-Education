Console.Clear();
void FillArray(int[] collection)
{
int length = collection.Length; 
int index = 0;
while(index < length)
    {
        collection[index] = new Random().Next();
        index++;
    } 

}
int[] array = new int[10];
FillArray(array);
int sum = 0;
int counter = 0;
for(counter = 0; counter <array.Length; counter++)
{
    if(counter%2 == 1) sum = sum + array[counter];
}
Console.WriteLine($"[{string.Join(", ", array)}] -> сумма нечетных элементов {sum}");