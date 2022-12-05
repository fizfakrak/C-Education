Console.Clear();
Console.Write("Введите номер квадранта: ");
int x = int.Parse(Console.ReadLine());

if(x  == 1)
    Console.Write("0 < x < +\u221E ; 0 < y < +\u221E ");
else if(x == 2)
    Console.Write("-\u221E < x < 0 ; 0 < y < +\u221E ");
else if(x == 3)
    Console.Write("-\u221E < x < 0 ; -\u221E < y < 0 ");
else if(x == 4)
    Console.Write("0 < x < +\u221E  ; -\u221E < y < 0 ");