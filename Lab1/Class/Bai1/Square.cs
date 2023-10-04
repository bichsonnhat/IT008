using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Square : Rectangle
    {
        public int x;
        public Square(int p) : base(p)
        {
            this.name = "Square";
        }
        public override void Read()
        {
            Console.WriteLine("Read a Edge of Square: ");
            x = int.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            return x * x;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Properties of Square: ");
            Console.WriteLine("Hai đường chéo bằng nhau, vuông góc và giao nhau tại trung điểm của mỗi đường");
            Console.WriteLine("Có 2 cặp cạnh song song");
            Console.WriteLine("Có 4 cạnh bằng nhau");
            Console.WriteLine("Có một đường tròn nội tiếp và ngoại tiếp đồng thời tâm của cả hai đường tròn trùng nhau và là giao điểm của hai đường chéo của hình vuông");
            Console.WriteLine("Một đường chéo sẽ chia hình vuông thành hai phần có diện tích bằng nhau");
            Console.WriteLine("Giao điểm của các đường phân giác, trung tuyến, trung trực đều trùng tại một điểm.");
        }
    }
}
