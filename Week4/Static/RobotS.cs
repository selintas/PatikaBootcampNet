using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class RobotS
    {
        private static int _robotCount; // ) static ) kullanmak sınıfa ait ama ornek new üretilmeden kullanılabılır. yenı bır ornek üretmeden robot sınıfından alınıp kullanılır.

        public static int RobotCount { get { return _robotCount; } set { _robotCount = value; } }
          
        static RobotS() // static ctor 
        {  
            _robotCount = 0;  // bu instance.
        } 
         
        public static void DisplayRobotCount() //  tüm robot nesnelerı kullanacak, sayısını vericek. 
        {  
            Console.WriteLine($"Toplam robot sayısı {_robotCount}");  
        }
       
        public string _name;
        public string _model;
        public int _batteryLevel;


        #region Metot Overloading
        // iki aynı isimde metot
        public RobotS() // boş bir ctor new ile kullanılabılecek
        {

        }


        public RobotS(string name, string model, int batteryLevel) // Constructor metodu
        {
            _name = name;
            _model = model;
            _batteryLevel = batteryLevel;
        }
        #endregion


        public void Introduce()
        {
            Console.WriteLine($"Merhaaba benım adım {_name} ve modelim {_model}");
        }

        public void ChargeBattery()
        {
            _batteryLevel = 100;
            Console.WriteLine("Pil şarj edildi");
        }
        public void PerformTask(string task)
        {
            if (_batteryLevel <= 10)
            {
                Console.WriteLine($"İşlem Başlatıldı: {task}");
                _batteryLevel -= 10;
            }
            else
            {
                Console.WriteLine("Pil seviyesi düşük. Lütfen pili şarj edilniz.");

            }
        }

        // yıkıcı metot - destructor -> temizlemek için nesne bellekteyken temizlenmek isteyen verileri otomatık olarak serbest bıeakarak ve geri donus return type yok
        ~RobotS()
        {


        }
    }
}
    