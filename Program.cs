using System;

namespace ParalelepipedoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a1 = r.Next(0, 10);
            int b1 = r.Next(0, 10);
            int c1 = r.Next(0, 10);
            Paralelepipedo a = new Paralelepipedo();
            a.volume();
            a.areaTotal();
            a.IsCube();
            a.Is3D();

            Paralelepipedo b = new Paralelepipedo(10);
            b.volume();
            b.areaTotal();
            b.IsCube();
            b.Is3D();

            Paralelepipedo c = new Paralelepipedo(a1, b1, c1);
            c.volume();
            c.areaTotal();
            c.IsCube();
            c.Is3D();
        }
    }
}
