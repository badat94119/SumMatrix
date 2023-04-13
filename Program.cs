using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap kich thuoc ma tran: ");
        int n = int.Parse(Console.ReadLine()); // kích thước ma trận nhập từ người dùng

        int[,] matrix = new int[n, n]; // khởi tạo ma trận

        // nhập liệu cho ma trận từ người dùng
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Nhap phan tu tai vi tri [{0},{1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i]; // tính tổng các phần tử trên đường chéo chính
        }

        Console.WriteLine("Tong cac phan tu tren duong cheo chinh la: " + sum);
    }
}

