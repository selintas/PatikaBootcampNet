using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Robot
    {
        public string name;
        public string model;
        public int batteryLevel;

        public void Introduce()
        {
            Console.WriteLine($"Merhaaba benım adım {name} ve modelim {model}");
        }

        public void ChargeBattery()
        {
            batteryLevel = 100;
            Console.WriteLine("Pil şarj edildi");
        }
        public void PerformTask(string task)
        {
            if (batteryLevel <= 10)
            {
                Console.WriteLine($"İşlem Başlatıldı: {task}");
                batteryLevel -= 10;
            }
            else
            {
                Console.WriteLine("Pil seviyesi düşük. Lütfen pili şarj edilniz.");

            }
        }
    }
}
