using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int m = 0;
            int n = 0;
            int[,] arr;
            Console.WriteLine("Nhập vào m:");
            m = SoLuong();
            Console.WriteLine("Nhập vào n:");
            n = SoLuong();
            arr = NhapNgauNhien(m, n);
            Console.WriteLine("Ma trận được nhập ngẫu nhiên là:");
            XuatMaTran(arr);
        }
        static void XuatMaTran(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
        static int[,] NhapNgauNhien(int m, int n)
        {
            int[,] arr = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(101);
                }
            }
            return arr;
        }
        static int SoLuong()
        {
            int x = 0;
            do
            {
                x = int.Parse(Console.ReadLine());
            } while (x <= 0);
            return x;
        }
    }
}
