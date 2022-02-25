using System;
using System.Text;

namespace BAI_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] arr;
            int m = 0;
            int n = 0;
            int[,] arr1;
            int x = 0;
            Console.WriteLine("Nhập vào chiều dài n:");
            n = SoLuong();
            Console.WriteLine("Nhập vào chiều dài m:");
            m = SoLuong();
            Console.WriteLine("Ma trận hình chữ nhật có dạng:");
            arr = NhapMaTran(m, n);
            XuatMaTran(arr);
            Console.WriteLine("Ma trận hình vuông có các cạnh hình chữ nhật nhỏ nhất có dạng:");
            if (m < n)
            {
                arr1 = Coppy(arr, m);
            }
            else
            {
                arr1 = Coppy(arr, n);
            }
            XuatMaTran(arr1);
            TichPTCuaCot(arr1);
            Console.WriteLine($"\nTích đường chéo chính của ma trận vuông là: {TichDuongCheoChinh(arr1)}");
            Console.WriteLine($"Tích đường chéo phụ của ma trận vuông là: {TichDuongCheoPhu(arr1)}");
            Console.WriteLine($"\nTổng các phần tử là số nguyên tố trong ma trận vuông là: {TichPTSNT(arr1)}");
            Console.WriteLine($"\nTrung bình cộng các số chẵn trong ma trận vuông là: {TrungBinhPTChan(arr1)}");
            Console.WriteLine($"\nPhần tử lẻ lớn nhất trong ma trận vuông là: {PTLeLonNhat(arr1)}");
            Console.WriteLine("\nNhập vào số cần xét:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số lần xuất hiện của {x} trong ma trận vuông là: {DemXuatHien(arr1, x)}");
            Console.WriteLine();
            SapXepTanngDan(ref arr1);
            XuatMaTran(arr1);
        }
        static void SapXepTanngDan(ref int[,] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i / arr.GetLength(1), i % arr.GetLength(1)] > arr[j / arr.GetLength(1), j % arr.GetLength(1)])
                    {
                        temp = arr[i / arr.GetLength(1), i % arr.GetLength(1)];
                        arr[i / arr.GetLength(1), i % arr.GetLength(1)] = arr[j / arr.GetLength(1), j % arr.GetLength(1)];
                        arr[j / arr.GetLength(1), j % arr.GetLength(1)] = temp;
                    }
                }
            }
        }
        static int DemXuatHien(int[,] arr, int x)
        {
            int dem = 0;
            foreach (int i in arr)
            {
                if (x == i)
                {
                    dem++;
                }
            }
            return dem;
        }
        static int PTLeLonNhat(int[,] arr)
        {
            int MaxLe = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0 && MaxLe < i)
                {
                    MaxLe = i;
                }
            }
            return MaxLe;
        }
        static double TrungBinhPTChan(int[,] arr)
        {
            double TBC = 0;
            int dem = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    dem++;
                    TBC += i;
                }
            }
            return TBC / dem;
        }
        static double TichPTSNT(int[,] arr)
        {
            double Tich = 0;
            foreach(int i in arr)
            {
                if (KiemTraSNT(i) == true)
                {
                    Tich += i;
                }
            }
            return Tich;
        }
        static bool KiemTraSNT(int x)
        {
            if (x == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
        static double TichDuongCheoPhu(int[,] arr)
        {
            int i = arr.GetLength(1) - 1;
            int j = 0;
            double Tich = 1;
            while (i >= 0)
            {
                Tich *= arr[j, i];
                i--;
                j++;
            }
            return Tich;
        }
        static double TichDuongCheoChinh(int[,] arr)
        {
            int i = 0;
            double Tich = 1;
            while (i <= arr.GetLength(1) - 1)
            {
                Tich *= arr[i, i];
                i++;
            }
            return Tich;
        }
        static void TichPTCuaCot(int[,] arr)
        {
            double Tich = 1;
            int dem = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Tich *= arr[j, i];
                }
                dem++;
                Console.WriteLine($"Tích các phần tử của cột {dem}: {Tich}");
                Tich = 1;
            }
        }
        static void XuatMaTran(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
        static int[,] Coppy(int[,] arr, int n)
        {
            int[,] arr1 = new int[n, n];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = arr[i, j];
                }
            }
            return arr1;
        }
        static int[,] NhapMaTran(int m, int n)
        {
            int[,] arr = new int[m, n];
            Random R = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = R.Next(21);
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
