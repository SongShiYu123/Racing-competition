using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Typr
    {
        private Random random = new Random();
        public void Tyre1(List<Driver>drivers)
        {
            for (int i = 0; i < drivers.Count; i++)
            {
                int b = random.Next(0, 100);//判断是否换轮胎
                if (b < 50)
                {
                    drivers[i].type = "Rainy tires";
                    drivers[i].sumTime = drivers[i].sumTime + 10;
                    Console.WriteLine("-{0} replace rainy tires,time increse 10", drivers[i].driverName);
                }
            }
        }
    }
}
