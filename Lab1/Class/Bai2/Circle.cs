using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Circle : Shape
    {
        public int r;
        public Circle(int p) : base(p)
        {
            this.name = "Circle";
        }
        public override void Read()
        {
            Console.WriteLine("Read a Radius of Circle: ");
            r = int.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            return (3.14 * r * r);
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Properties of Circle: ");
            Console.WriteLine("Góc ở tâm đường tròn bằng 360 độ.");
            Console.WriteLine("Đường kính là đoạn thẳng dài nhất trong một hình tròn.");
            Console.WriteLine("Các đường tròn bằng nhau có chu vi bằng nhau.");
            Console.WriteLine("Một tiếp tuyến của đường tròn nằm ở một góc vuông với bán kính tại điểm tiếp xúc.");
            Console.WriteLine("Hai tiếp tuyến được vẽ trên một đường tròn từ một điểm bên ngoài có chiều dài bằng nhau.");
            Console.WriteLine("Đường tròn là hình có tâm và vô số trục đối xứng với nhau.");
        }
    }
}
