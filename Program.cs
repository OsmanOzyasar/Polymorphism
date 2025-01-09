using System;
using System.Drawing;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Square square = new Square();
            Console.WriteLine("Kare Alanı: " + square.AlanHesapla(5, 5) + " cm kare"); 

            BaseGeometrikSekil sekil = new Triangle();
            Console.WriteLine("Üçgen alanı: " + sekil.AlanHesapla(7, 8) + " cm kare");

            Ractangle ractangle = new Ractangle();
            Console.WriteLine("Dikdörtgen alanı: " + ractangle.AlanHesapla(12,8) + " cm kare");
        }
    }
}