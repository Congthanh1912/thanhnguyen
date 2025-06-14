// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
namespace haha
{
    public static class Thanhnn
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("so tien gui");
            float tiengoi = float.Parse(Console.ReadLine());
            Console.WriteLine("phan tram lai suat");
            float phantramlaisuat = float.Parse(Console.ReadLine());
            Console.WriteLine("So nam gui");
            int sonamgui = int.Parse(Console.ReadLine());

            double tiennhan = tiengoi * Math.Pow((1 + phantramlaisuat / 100), sonamgui);
            Console.WriteLine($"tien nhan{tiennhan}");








        }
    }
}
