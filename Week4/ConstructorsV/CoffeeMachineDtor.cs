using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsV
{
    public class CoffeeMachineDtor
    { 
        public CoffeeMachineDtor() { } // boş ctor

        // cTor tanımlama
        public CoffeeMachineDtor(string model, int waterLevel, int coffeeBeans)  
        {  
            _model = model;
            _waterLevel = waterLevel; 
            _coffeeBeans = coffeeBeans;

        }

        // sadece model kullanmak istioyrsak sadece model olan ctor oluştur  sadece model gir 
        public CoffeeMachineDtor(string model)
        {
            _model = model;

        }

        // yıkıcı 

        ~CoffeeMachineDtor()
        {
            //
        }


        private string _model;
        private int _waterLevel;
        private int _coffeeBeans; // fields (alanlar) 

        //properties get ve set ile:

        public string Model
        { get { return _model; } set { _model = value; } }

        public int WaterLevel //properties açık süslü parantez ile yazımı
        {
            get
            {
                return _waterLevel;
            }

            set
            {
                if (value >= 0)
                {
                    _waterLevel = value;
                }
            }
        }
        public int CoffeeBeans // propertıes getset kapalı sekılde yazım
        {
            get { return _coffeeBeans; }
            set { if (value >= 0) { _coffeeBeans = value; } }  //degerlerın sıfırdan buyuk olması ıf saglandı..
        }

        //metot oluşturma kahve yapımı 
        public void MakeCoffee() //method
        {
            if (_waterLevel >= 200 && _coffeeBeans >= 15)
            {
                Console.WriteLine("Kahve Hazır");
                _coffeeBeans -= 15;    
                _waterLevel -= 200;
            }
            else
            {
                Console.WriteLine("Yeterli su veya kahve çekirdeği yok");
            }
        }

        public void AddWater(int amount)
        {
            if (amount > 0)
            {
                _waterLevel += amount;
                Console.WriteLine($"{amount} ml su eklendi. Güncel su seviyesi {_waterLevel} ml");
            }
        }
        public void AddCoffeeBeans(int amount)
        {
            if (amount > 0)
            {
                _coffeeBeans += amount;
                Console.WriteLine($"{amount} gram kahve çekirdeği eklendi. Güncel kahve miktarı {_coffeeBeans} gram");
            }
        }
    }
}

// *** program.cs kısmı yazılmadı ona oncekınden bak.