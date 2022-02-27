// Нахождение максимального из трех чисел.

Console.WriteLine("ввведите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввведите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввведите число c");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA ;
 if (numberB > max) max = (numberB);
 if (numberC > max)  max = (numberC);
Console.WriteLine ("Максимальное из трех " + max);