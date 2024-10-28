using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConstructorsV
{
    public class RobotC
    {
        public string _name;
        public string _model;
        public int _batteryLevel; 


        #region Metot Overloading
        // iki aynı isimde metot
        public RobotC() // boş bir ctor new ile kullanılabılecek
        {

        }


        public RobotC(string name, string model, int batteryLevel) // Constructor metodu
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
        ~RobotC()  
        {  
            

        }
    }
}
