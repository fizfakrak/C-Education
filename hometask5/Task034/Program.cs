Console.Clear();
void FillArray(int[] collection)
{
int length = collection.Length; 
int index = 0;
while(index < length)
    {
        collection[index] = new Random().Next(100,1000);
        index++;
    } 

}
int[] array = new int[10];
FillArray(array);
int even_counter = 0;
int counter = 0;
for(counter = 0; counter <array.Length; counter++)
{
    if(array[counter]%2 == 0) even_counter++;
}
Console.WriteLine($"[{string.Join(", ", array)}] -> {even_counter}");