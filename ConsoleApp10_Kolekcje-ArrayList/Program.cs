using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_Kolekcje_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(102);
            list.Add("Rudy");
            list.Add(new Auto("BMW"));
            list.RemoveAt(1);
            list.Insert(1, "Mercedes");

            //Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            List<Motor> motors = new List<Motor>();
            motors.Add (new Motor("Yamaha", 2019));
            motors.Add (new Motor("Honda", 2000));
            motors.Add (new Motor("BMW", 2015));

            foreach (Motor item in motors)
            {
                Console.WriteLine(item.Marka +" "+ item.Rok);
            }

            //Motor m1 = new Motor("Yamaha",2019);
            //Console.WriteLine($"{m1.marka}{m1.rok}");
            //m1.Sound();
            Console.ReadKey();
        }
    }

}
