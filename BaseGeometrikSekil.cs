using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class BaseGeometrikSekil
    {
        public int Height {  get; set; }
        public int Width { get; set; }

        public virtual double AlanHesapla(int height, int width)
        {
            Height = height; 
            Width = width;
            return (double) height * width;
        }
    }

    public class Triangle : BaseGeometrikSekil
    {
        public override double AlanHesapla(int height, int width)
        {
            return (double)(height * width) / 2;
        }
    }

    public class Square : BaseGeometrikSekil
    {
        public override double AlanHesapla(int height, int width)
        {
            return base.AlanHesapla(height, width);
        }
    }

    public class Ractangle : BaseGeometrikSekil
    {
        public override double AlanHesapla(int height, int width)
        {
            return base.AlanHesapla(height, width);
        }
    }
}
