﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Nasya_putri_R.A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace _19.Fachdiral_Lazuardy
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("APLIKASI");
                Console.WriteLine("LIST BILANGAN PRIMA");
                Console.WriteLine("---------------------------------------------------------");

                Console.WriteLine("NAMA: Nasya Putri R.A");
                Console.WriteLine("KELAS: X-PPLG");
                Console.WriteLine("ABSEN: 25");
                Console.WriteLine("------------------------------------------------------------");

                for (int num = 2; num <= 1000; num++)//Melakukan looping dari bilangan 2 hingga 1000
                {
                    bool isPrima = true;//Menetapkan bilangan prima menjadi isPrimme dan membuat isPrime menjadi true
                    for (int pembagi = 2; pembagi <= Math.Sqrt(num); pembagi++)//Melakukan loop dari 2 hingga ke akar kuadrat dari num
                    {
                        if (num % pembagi == 0)//Jika num habis dibagi oleh angka di dalam loop 
                        {
                            isPrima = false;//Maka isPrime diatur menjadi false
                            break;//Maka akan di berhentikan
                        }
                    }


                    if (isPrima)//Jika setelah melakukan loop isPrime masih true
                    {
                        Console.WriteLine(num + " ");//Maka num yang telah di filter akan ditampilkan ke dalam list bilangan prima pada console
                    }
                }
            }
        }
    }

}

    }
}
