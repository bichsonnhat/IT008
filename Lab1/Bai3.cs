using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static T FindMax<T>(IEnumerable<T> sequence)
    {
        if (sequence == null || !sequence.Any())
            return default(T);

        if (typeof(T) == typeof(int) || typeof(T) == typeof(double))
        {
            return sequence.Max();
        }
        else if (typeof(T) == typeof(string))
        {
            return sequence.OrderByDescending(item => (item as string).Length).First();
        }

        return default(T);
    }

    static T FindMin<T>(IEnumerable<T> sequence)
    {
        if (sequence == null || !sequence.Any())
            return default(T);

        if (typeof(T) == typeof(int) || typeof(T) == typeof(double))
        {
            return sequence.Min();
        }
        else if (typeof(T) == typeof(string))
        {
            return sequence.OrderBy(item => (item as string).Length).First();
        }

        return default(T);
    }

    static void Main()
    {
        Console.OutputEncoding = UnicodeEncoding.Unicode;
        Console.InputEncoding = UnicodeEncoding.Unicode;
        Console.WriteLine("Nhập dãy số nguyên: ");
        List<int> integerSequence = new List<int>();
        string input = Console.ReadLine();
        integerSequence.AddRange(input.Split(' ').Select(int.Parse));

        Console.WriteLine("Nhập dãy số thực: ");
        List<double> floatSequence = new List<double>();
        input = Console.ReadLine();
        floatSequence.AddRange(input.Split(' ').Select(double.Parse));

        Console.WriteLine("Nhập dãy chuỗi: ");
        List<string> stringSequence = new List<string>();
        input = Console.ReadLine();
        stringSequence.AddRange(input.Split(' '));

        var maxInt = FindMax(integerSequence);
        var maxFloat = FindMax(floatSequence);
        var maxString = FindMax(stringSequence);

        var minInt = FindMin(integerSequence);
        var minFloat = FindMin(floatSequence);
        var minString = FindMin(stringSequence);

        Console.WriteLine("Số lớn nhất trong dãy số nguyên: " + maxInt);
        Console.WriteLine("Số lớn nhất trong dãy số thực: " + maxFloat);
        Console.WriteLine("Chuỗi dài nhất trong dãy chuỗi: " + maxString);

        Console.WriteLine("Số nhỏ nhất trong dãy số nguyên: " + minInt);
        Console.WriteLine("Số nhỏ nhất trong dãy số thực: " + minFloat);
        Console.WriteLine("Chuỗi ngắn nhất trong dãy chuỗi: " + minString);
    }
}
