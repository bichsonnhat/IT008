using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;

namespace MainProgram
{
    internal class PS : IComparable<PS>
    {
        private int TuSo { get; set; }
        private int MauSo { get; set; }
        public PS(int TuSo = 0, int Mauso = 1)
        {
            this.TuSo = TuSo;
            this.MauSo = Mauso;
        }
        public static PS StringToPS(string? str)
        {
            bool negative = false;
            if (str == null) return new PS(0, 1);
            if (str.Substring(0, 1) == "-")
            {
                negative = true;
                str = str.Remove(0, 1);
            }
            if (str.IndexOf('/') == -1) return new PS((negative ? -1 : 1) * Int32.Parse(str), 1);
            string[] s = str.Split('/');
            int tuSo = Int32.Parse(s[0]);
            int mauSo = Int32.Parse(s[1]);
            return new PS((negative? -1: 1) * tuSo, mauSo).RutGon();
        }
        public static PS operator +(PS a, PS b) 
            => new PS((a.TuSo * b.MauSo) + (a.MauSo * b.TuSo), a.MauSo * b.MauSo).RutGon();

        public static PS operator -(PS a, PS b)
        {
            return a + new PS(-b.TuSo, b.MauSo);
        }
        public static PS operator *(PS a, PS b)
            =>  new PS(a.TuSo * b.TuSo, a.MauSo * b.MauSo).RutGon();
        
        public  static PS operator /(PS a, PS b)
        {
            if (b.TuSo == 0)
                throw new DivideByZeroException();
            b = new PS(b.MauSo, b.TuSo);
            return a * b;
        }

        public static bool operator ==(PS a, PS b)
            => ((a.TuSo == b.TuSo) && (a.MauSo == b.MauSo));
        public static bool operator !=(PS a, PS b)
            => !(a == b);
        public static bool operator >(PS a, PS b)
            => ((a - b).TuSo > 0);

        public static bool operator <(PS a, PS b)
            => !((a > b) || (a == b));

        public override string ToString() 
            => $"{(TuSo * MauSo < 0 ? "-" : "")}{Math.Abs(TuSo)}{(Math.Abs(MauSo) != 1 ? $"/{Math.Abs(MauSo)}" : "")}";
        private static int GCD(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }

        public PS RutGon()
        {
            bool negative = (this.TuSo < 0);
            if (negative) this.TuSo = this.TuSo * -1;
            int gcd = GCD(this.TuSo, this.MauSo);
            return new PS((negative ? -1 : 1) * this.TuSo / gcd, this.MauSo / gcd);
        }

        public double ToDouble()
        {
            return (double)TuSo / MauSo;
        }

        public int CompareTo(PS? other)
        {
            return this.ToDouble().CompareTo(other.ToDouble());
        }

        public static explicit operator PS(int value)
        {
            return new PS(value, 1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phan so thu nhat (a/b): ");
            PS a = PS.StringToPS(Console.ReadLine()); 
            Console.WriteLine("Phan so thu hai (a/b): ");
            PS b = PS.StringToPS(Console.ReadLine());

            Console.WriteLine($"a = {a.ToString()}");
            Console.WriteLine($"b = {b.ToString()}");

            PS sum = a + b;
            Console.WriteLine($"a + b = {sum.ToString()}");
                
            PS sub = a - b;
            Console.WriteLine($"a - b = {sub.ToString()}");

            PS mul = a * b;
            Console.WriteLine($"a * b = {mul.ToString()}");

            PS div = a / b;
            Console.WriteLine($"a / b = {div.ToString()}");

            Console.WriteLine($"a == b: {a == b}\n" +
                $"a != b: {a != b}\n" +
                $"a > b: {a > b}\n" +
                $"a < b: {a < b}");
            Console.WriteLine((PS)3 + new PS(1, 2));


            List<PS> arrayList = new List<PS>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"PS[{i}] = ");
                arrayList.Add(PS.StringToPS(Console.ReadLine()));
            }
            arrayList.Sort();
            for (int i = 0; i < 3; i++)
                Console.WriteLine($"PS[{i}] = {arrayList[i].ToString()}");
        }
    }
}
