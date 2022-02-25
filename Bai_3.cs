using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] arr = new int[4, 4];
            arr = NhapMaTran();
            XuatMaTran(arr);

        }
        static void XuatMaTran(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}  ");
                }
                Console.WriteLine();
            }
        }
        static int[,] NhapMaTran()
        {
            int[,] arr = new int[4, 4];
            for (int i = arr.GetLength(0)/2; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    arr[j, i] = arr[i, j];
                }
                Console.WriteLine();
            }
            return arr;
        }
    }
}
