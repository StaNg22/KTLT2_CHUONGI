using System;
using System.Text;

namespace BAI_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[,] arr;
            int n = 0;
            Console.WriteLine("Nhập vào n:");
            n = SoLuong();
            arr = NhapPascal(n);
            Console.WriteLine("-+-+-+ABC+-+-+-");
            XuatMaTran(arr);
        }
        static void XuatMaTran(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }
        }
        static string[,] NhapPascal(int n)
        {
            long nGiaThua = 1;
            long kGiaThua = 1;
            long HieuGiaThua = 1;
            string[,] arr = new string[n, n];
            arr[0, 0] = "1";
            for (int i = 1; i < n; i++)
            {
                nGiaThua *= i;
                arr[i, i] = "1";
                for (int k = 0; k < i; k++)
                {
                    if (k == 0)
                    {
                        arr[i, k] = "1";
                    }
                    else
                    {
                        kGiaThua *= k;
                        for (int dem = 0; dem <= i - k; dem++)
                        {
                            if (dem == 0)
                            {
                                HieuGiaThua = 1;
                            }
                            else
                            {
                                HieuGiaThua *= dem;
                            }
                        }
                        arr[i,k]= (nGiaThua / (kGiaThua * HieuGiaThua)).ToString();
                    }
                }
                kGiaThua = 1;
                HieuGiaThua = 1;
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
