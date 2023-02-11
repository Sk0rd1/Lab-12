using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Sphere
    {
        private float Radius { get; set; }

        public float GetVolume()
        {
            return (float)Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            string strVolume = string.Format("{0:F" + 2 + "}", GetVolume());
            string strRadius = string.Format("{0:F" + 2 + "}", Radius);
            return "Sphere : radius = " + strRadius + ", volume = " + strVolume + ".";
        }

        public static Sphere operator +(Sphere left, Sphere right)
        {
            return new Sphere { Radius = (float)Math.Sqrt(left.Radius * left.Radius + right.Radius * right.Radius) };
        }

        public Sphere() : this(0) { }

        public Sphere(float Radius)
        {
            this.Radius = Radius;
        }

        public Sphere(Sphere other) 
        {
            this.Radius = other.Radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var sphere1 = new Sphere();
            var sphere2 = new Sphere(5);
            var sphere3 = new Sphere(4);
            var sphere4 = sphere2 + sphere3;
            Console.WriteLine(sphere2.ToString());
            Console.WriteLine(sphere3.ToString());
            Console.WriteLine(sphere4.ToString());
            Console.ReadKey();
        }
    }
}
