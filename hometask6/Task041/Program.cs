Console.Clear();
int length = new Random().Next(10,21);
int[] array = new int [length];
int counter = 0;
int number_counter = 0;
for(counter = 0; counter < array.Length; counter++)
{
    Console.Write($"Введите {counter} число в массив = ");
    array[counter] = int.Parse(Console.ReadLine());
    if(array[counter] > 0) number_counter++;
}
Console.Write($"Количество чисел больше нуля = {number_counter} ");