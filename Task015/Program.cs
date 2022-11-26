Console.Clear();
Console.Write("Введите порядковый номер дня :");
int input_number = int.Parse(Console.ReadLine());
switch(input_number)
{
    case 1: 
    case 2: 
    case 3: 
    case 4: 
    case 5: {Console.Write("Это не выходной день"); break;}
    case 6: 
    case 7: {Console.Write("Это выходной день"); break;}
    default: {Console.Write("нет соотв дня"); break;}
}