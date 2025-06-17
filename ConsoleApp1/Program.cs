// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
namespace haha
{
    public static class Thanhnn
    {
        public static void Main(string[] args)
        /* 
             Console.WriteLine("so tien gui");
             float tiengoi = float.Parse(Console.ReadLine());
             Console.WriteLine("phan tram lai suat");
             float phantramlaisuat = float.Parse(Console.ReadLine());
             Console.WriteLine("So nam gui");
             int sonamgui = int.Parse(Console.ReadLine());

             double tiennhan = tiengoi * Math.Pow((1 + phantramlaisuat / 100), sonamgui);
             Console.WriteLine($"tien nhan{tiennhan}");*/

        {
            /* int a = int.Parse(Console.ReadLine());

             if (a % 2 == 0)
             {
                 Console.WriteLine("a la so chan");
             }
             else
             {

                 Console.WriteLine("a la so le");
             }*/
            
            Random songaunhien = new Random();
            int c = songaunhien.Next(4);
            string luachon;
            if (c == 1)
            {
                luachon = "keo";
            }
            else if (c == 2) 
            {
                luachon = "bua";
            }
            else
            {
                luachon = "bao";
            }
            string luachonnguoichoi= Console.ReadLine();
            Console.WriteLine($"lua chon cua ban la {luachonnguoichoi}");
            if (luachonnguoichoi == luachon)
            {
                Console.WriteLine("hoa" + $"lua chon cua may la {luachon}");
            }
            else if 
                (luachonnguoichoi == "keo" && luachon == "bua"
                || luachonnguoichoi == "bua" && luachon == "bao"
                || luachonnguoichoi == "bao" && luachon == "keo")
            {
                Console.WriteLine("thua" + $"lua chon cua may la {luachon}");
            }
            else 
            { Console.WriteLine("thang" + $"lua chon cua may la {luachon}");                
            }
            







        }
    }
}










