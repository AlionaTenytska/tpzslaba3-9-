//Змініть програму так, щоб вона видаляла k-тий стовпець в двовимірному масиві.

using System;

namespace tpzslaba3_9_
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }
        static void Print(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; ++i, Console.WriteLine())
                for (int j = 0; j < m; ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static void DeleteArray(int[,] a, ref int n, int m, int k)
        {
            for (int i = 0; i < n ; ++i)
                for (int j = k; j < m-1; ++j)
                    a[i, j] = a[i , j+1];
            m=m-1;

        }
        static void Main()
        {
            int n, m;
            int[,] myArray = Input(out n, out m);
            Console.WriteLine("Исходный массив: ");
            Print(myArray, n, m);
            Console.WriteLine("Введите номер строки для удаления:");
            int k = int.Parse(Console.ReadLine());
            DeleteArray(myArray, ref n, m, k);
            Console.WriteLine("Измененный массив:");
            Print(myArray, n, m-1);
            Console.ReadKey();
        }
      
    }
}
