using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCS.structure
{
    struct Point3D
    {
        public int x, y, z;

        public Point3D(int X, int Y, int Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        public override string ToString()
        {
            return string.Format($"{x},{y},{z}");
        }
    }
    class structure_class
    {
        static void Main(string[] args)
        {
            Point3D p1;
            p1.x = 10;
            p1.y = 20;
            p1.z = 30;

            Console.WriteLine(p1.ToString());

            Point3D p2 = new Point3D(100, 200, 300);
            Point3D p3 = p2;
            p3.z = 400;

            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
        }
    }
}
