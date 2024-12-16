using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rain
    {
        private Random random = new Random();
        public void Rainprobility(int n,ref int judg,List<Driver> drivers,float possibility)
        {
            int a = random.Next(0, 100);
            if(a<possibility*100&&judg == 0)
            {
                judg++;
                Console.WriteLine("Weather is rainning");
                Console.WriteLine("-------------------");
            }
            if (n == 2)
            {
                Typr tyre = new Typr();//判断是否换胎
                tyre.Tyre1(drivers);
            }
            for (int i = 0; i < drivers.Count; i++)
            {
                if(judg == 1&&drivers[i].type == "Dry tires")
                {
                    drivers[i].sumTime = drivers[i].sumTime + 5;
                    Console.WriteLine("The rain caused the {0} time to increase by five seconds", drivers[i].driverName);
                }
            }
        }
    }
}
