using System;

namespace QUIZ09092019
{
    class bangunDatar
    {
        public void luasPersegi()
        {
            int sisi;
            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("-----------------------");
            Console.Write("Masukkan nilai sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;
            Console.WriteLine("Nilai luas adalah : "+luas);
            Console.WriteLine(" ");
        }
        public void luasSegitiga()
        {
            Console.WriteLine("Menghitung Nilai Luas Segitiga");
            Console.WriteLine("------------------------------");
            int alas, tinggi;
            Console.Write("Masukkan nilai alas segitiga : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi segitiga : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            int y = 2;
            int luasS = alas * tinggi / y;
            Console.WriteLine("Luas segitiga adalah : " + luasS);
            Console.WriteLine(" ");

        }
        public void luasLingkaran()
        {
            Console.WriteLine("Menghitung Nilai Luas Lingkaran");
            Console.WriteLine("------------------------------");
            double phi = 3.14;
            Console.Write("Masukkan jari-jari lingkaran : ");
            int jari2 = Convert.ToInt32(Console.ReadLine());
            double luasL = phi * jari2 * jari2;
            Console.WriteLine("Luas Lingkaran adalah : " + luasL);
            Console.WriteLine(" ");
        }
    }
}
