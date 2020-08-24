using System;

namespace oop_6115261014_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Img i1 = new Img("sea", "700","500", "22042020", "JPG");
            Album a1 = new Album("001", "viwe", "22042020", "img",  i1);
            Console.WriteLine(a1.ToString());
            Img i2 = new Img("mountain", "600", "500", "23042020", "PNG");
            Album a2 = new Album("002", "viwe", "23042020", "img", i2);
            Console.WriteLine(a2.ToString());
        }
    }
}