using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Triangle : Shape
    {
        public int a, b, c;
        public Triangle(int p) : base(p)
        {
            this.name = "Triangle";
        }
        public override void Read()
        {
            Console.WriteLine("Read 3 Edges of Triangle: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Properties of Triangle: ");
            Console.WriteLine("Tổng số đo các góc trong của 1 hình tam giác bằng 180°.");
            Console.WriteLine("Độ dài mỗi cạnh sẽ lớn hơn hiệu độ dài 2 cạnh còn lại, nhỏ hơn tổng độ dài của chúng.");
            Console.WriteLine("Trong 1 hình tam giác, cạnh đối diện với góc lớn hơn chính là cạnh lớn nhất. Ngược lại, góc đối diện cạnh lớn hơn chính là góc lớn hơn.");
            Console.WriteLine("3 đường cao của hình tam giác sẽ cắt nhau tại 1 điểm gọi là trực tâm của tam giác.");
            Console.WriteLine("3 đường trung tuyến hình tam giác cắt nhau tại 1 điểm gọi là trọng tâm. Hay 3 đường trung tuyến của hình đồng quy tại 1 điểm, khoảng cách từ trọng tâm đến 3 đỉnh tam giác sẽ bằng 2/3 độ dài đường trung tuyến ứng với đỉnh đó. Đồng thời, đường trung tuyến tam giác sẽ chia hình làm 2 phần có diện tích bằng nhau.");
            Console.WriteLine("3 đường trung trực của tam giác cắt nhau tại một điểm là tâm đường tròn ngoại tiếp của tam giác.");
            Console.WriteLine("3 đường phân giác trong của hình tam giác cắt nhau tại một điểm là tâm đường tròn nội tiếp của tam giác.");
            Console.WriteLine("Trong hình tam giác, đường phân giác của một góc chia cạnh đối diện thành 2 đoạn thẳng tỷ lệ với 2 cạnh kề 2 đoạn thẳng đó.");
        }
    }
}
