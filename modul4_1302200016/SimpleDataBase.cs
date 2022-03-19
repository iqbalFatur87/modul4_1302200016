using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200016
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T datanew)
        {
            storedData.Add(datanew);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                T datanew = storedData[i];
                DateTime dateTime = inputDates[i];
                Console.WriteLine("Data " + (i + 1) + "yang terdapat : " + datanew + "disimpan pada waktu " + dateTime);
            }
        }
    }
}
