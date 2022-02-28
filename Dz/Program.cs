// Программа вывода максимального числа и минимального  числа, из двух чисел. 

Console.WriteLine("ввведите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввведите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("max = " + numberA);
    Console.WriteLine("min = " + numberB);
}
else
{
    Console.WriteLine("max = " + numberB);
    Console.WriteLine("min = " + numberA);
}

// простой код

int namber1 = 9;
int namber2 = 12;
if (namber1 < namber2)
{
    Console.WriteLine("меньшее число " + namber1);
    Console.WriteLine("большее число " + namber2);
}
else
{
    Console.WriteLine("меньшее число " + namber2);
    Console.WriteLine("большее число " + namber1);
}