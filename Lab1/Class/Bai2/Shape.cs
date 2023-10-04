using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Shape
    {
        public int pos;
        public string name;
        public Shape(int p)
        {
            pos = p;
        }
        virtual public void Read()
        {

        }
        virtual public void Draw()
        {
            Console.WriteLine("Position: ", pos);
        }
        public virtual double Area(){ return 0; }
    }
}
