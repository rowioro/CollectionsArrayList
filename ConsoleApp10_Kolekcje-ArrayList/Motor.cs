using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_Kolekcje_ArrayList
{
    class Motor
    {
        public int Rok { get; set; }
        public string Marka { get; set; }

        public Motor(string m="BRAK", int r=0)
        {
            Marka = m;
            Rok = r;
        }

        public void Sound()
        {
            Console.WriteLine("wrwrwrwrwrwr");
        }
    }
}
