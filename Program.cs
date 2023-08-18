// See https://aka.ms/new-console-template for more information
using Algorithms;
using static System.Runtime.InteropServices.JavaScript.JSType;

while(true) 
{
    Console.WriteLine("1.Factorial");
    Console.WriteLine("2.LinearSearcher");
    Console.WriteLine("3.BinarySearcher");
    Console.WriteLine("4.FastSearcher");
    Console.WriteLine("5.BinaryInsertionSorter");
    Console.WriteLine("6.BubbleSorter");
    int a = int.Parse(Console.ReadLine());

    if (a == 1)
    {
        Console.Write("Please enter the number :");
        int number = int.Parse(Console.ReadLine());

        MyAlgorithms algorithms = new MyAlgorithms();
        int factorial = algorithms.Factorial(number);
        Console.WriteLine(factorial.ToString());
    }
    else if (a == 2)
    {
        string[] nam = new string[5];
        for (int i = 0; i < nam.Length; i++)
        {
            Console.Write("Please enter the  Name :");
            nam[i] = Console.ReadLine();
        }
        Console.Write("Please enter the search :");
        string search = Console.ReadLine();

        MyAlgorithms algorithms = new MyAlgorithms();
        bool result = algorithms.LinearSearcher(nam,search);
        Console.WriteLine(result.ToString());
    }
    else if (a == 3)
    {
        int[] number = new int[5];
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("Please enter the  number :");
            number[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter the search :");
        int search = int.Parse(Console.ReadLine());

        MyAlgorithms algorithms = new MyAlgorithms();
        bool result = algorithms.BinarySearcher(number, search);
        Console.WriteLine(result.ToString());
    }
    else if (a == 4)
    {
        
    }
    else if (a == 5)
    {
        int[] number = new int[10];
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("Please enter the  number :");
            number[i] = int.Parse(Console.ReadLine());
        }

        MyAlgorithms algorithms = new MyAlgorithms();
        number = algorithms.BinaryInsertionSort(number);
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
        }
    }
    else if (a == 6)
    {
        int[] number = new int[10];
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write("Please enter the  Name :");
            number[i] = int.Parse(Console.ReadLine());
        }

        MyAlgorithms algorithms = new MyAlgorithms();
        number = algorithms.BubbleSorter(number);
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine(number[i]);
        }
    }
}
