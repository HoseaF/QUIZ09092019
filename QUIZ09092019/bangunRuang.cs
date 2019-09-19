using System;

namespace QUIZ09092019
{
    class bangunRuang
    {
    public void volumeBalok()
        {
            int tinggi, panjang, lebar, volume;
            
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-----------------------");

            Console.Write("Masukkan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Masukkan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Masukkan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume balok adalah "+volume);
            Console.WriteLine(" ");
        }
        public void volumeKubus()
        {
            int sisi;
            Console.WriteLine("Menghitung nilai kubus");
            Console.WriteLine("----------------------");
            Console.Write("Masukkan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());
            int volume = sisi * sisi * sisi;
            Console.WriteLine("Volume kubus adalah "+volume);
        }
    }
}