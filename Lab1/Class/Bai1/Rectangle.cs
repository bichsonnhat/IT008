using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Rectangle : Shape
    {
        public int L, W;
        public Rectangle(int p) : base(p) { 
            this.name = "Rectangle";
        }
        public override void Read()
        {
            Console.WriteLine("Read Length of Rectangle: ");
            L = int.Parse(Console.ReadLine());
            Console.WriteLine("Read Width of Reactangle: ");
            W = int.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            return L * W;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Properties of Rectangle: ");
            Console.WriteLine("Các cặp cạnh đối luôn song song và bằng nhau");
            Console.WriteLine("Các góc bằng nhau và bằng 90°");
            Console.WriteLine("Hai đường chéo bằng nhau và cắt nhau tại tâm 4 các cạnh bằng nhau của mỗi hàng tạo thành tam giác.");
            Console.WriteLine("Các đường chéo của hình chữ nhật cắt nhau và tạo thành 4 tam giác đều. Trong toán tích phân, tích phân Riemann có thể coi là giới hạn của tổng diện tích của nhiều hình chữ nhật có chiều rộng rất nhỏ.");
            Console.WriteLine("Nội tiếp đường tròn có tâm là tâm (giao điểm của hai đường chéo)");
        }
    }
}
