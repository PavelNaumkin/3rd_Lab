using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] mas = new double[n];
        double[] mas2 = new double[5];
        double[] nechet = new double[5];
        int k = 0;
        double sum = 0;
        int t = 0;
        int p = 0;
        double lenght = 0;
        Console.WriteLine("Enter the array elements: ");
        for (int i=0; i<n; i++)
        {
            mas[i]=Convert.ToDouble(Console.ReadLine());
        }
        double max = mas[0];
        double min = mas[0];
        for (int i = 0; i < n; i++)
        {
            if (mas[i]<min && mas[i]>=0) { p = i; min = mas[i]; }
        }
        for (int i=p+1; i<n; i++)
        {
            mas[i - 1] = mas[i];
        }
        Console.WriteLine();
        Console.WriteLine("New array: ");
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(mas[i] + " ");
        }

        return 0;
    }
}