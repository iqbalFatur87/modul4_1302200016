using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200016
{
    internal class Penjumlahan<T>
    {
        public T JumlahTigaAngka(T bil1, T bil2, T bil3)
        { 
            dynamic tmp = bil1;
            tmp += bil2;
            tmp += bil3;

            return tmp;
        }
    }
}
