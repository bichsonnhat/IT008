using System;
using System.IO;

namespace DrtSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập đường dẫn thư mục: ");
            string folderPath = Console.ReadLine();
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);
                if (files.Length > 0)
                {
                    Console.WriteLine("Các tệp trong thư mục:");
                    foreach (string filePath in files)
                    {
                        Console.WriteLine(filePath);
                    }
                } else
                {
                    Console.WriteLine("Không có tệp nào trong thư mục.");
                }
            } else
            {
                Console.WriteLine("Đường dẫn thư mục không tồn tại.");
            }
        }
    }
}