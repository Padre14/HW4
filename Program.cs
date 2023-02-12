// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Task 25");
System.Console.WriteLine("Enter number A:");
int numA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number B:");
int numB = int.Parse(Console.ReadLine());
    
int Exponentiation = GetExponentiation(numA, numB);
System.Console.WriteLine(+Exponentiation);
    
int GetExponentiation (int number1, int number2)
{
    int result = 1;
    for (int i =1; i <= numB; i++)
    {
        result = result*numA;
    }
    return result;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


System.Console.WriteLine ("Enter number:");
    int number = int.Parse (Console.ReadLine ());

    int result = 0;
    for (; number > 0; number = number / 10)
    {
	    result = result + number%10;

    }

    System.Console.WriteLine (+result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[]massiv = GetArray(8, 0, 999);


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
         res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}



PrintArray(massiv);






