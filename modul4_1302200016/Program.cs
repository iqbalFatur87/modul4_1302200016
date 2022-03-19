using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menampilkan Simple Database dan Penjumlahan
            SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();

            simpleDataBase.AddNewData(13);
            simpleDataBase.AddNewData(02);
            simpleDataBase.AddNewData(20);

            simpleDataBase.PrintAllData();
            int bil1 = 13;
            int bil2 = 02;
            int bil3 = 20;

            Penjumlahan<int> penjumlahan = new Penjumlahan<int>();
            int result = penjumlahan.JumlahTigaAngka(bil1, bil2, bil3);

            Console.WriteLine(result);
        }
    }
}
