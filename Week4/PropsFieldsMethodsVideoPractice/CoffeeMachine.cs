using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsFieldsMethodsVideoPractice
{
    public class CoffeeMachine
    {
        private string model;
        private int waterLevel;
        private int coffeeBeans; // fields (alanlar) 

        //properties get ve set ile:

        public string Model
        { get { return model; } set { model = value; } }

        public int WaterLevel //properties açık süslü parantez ile yazımı
        {
            get
            {
                return waterLevel;
            }

            set
            {
                if (value >= 0)
                {
                    waterLevel = value;
                }
            }
        }
        public int CoffeeBeans // propertıes getset kapalı sekılde yazım
        {
            get { return coffeeBeans; }
            set { if (value >= 0) { coffeeBeans = value; } }  //degerlerın sıfırdan buyuk olması ıf saglandı..
        }

        //metot oluşturma kahve yapımı 
        public void MakeCoffee() //method
        {
            if (waterLevel >= 200 && coffeeBeans >= 15)
            {
                Console.WriteLine("Kahve Hazır");
                coffeeBeans -= 15;
                waterLevel -= 200;
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
                waterLevel += amount;
                Console.WriteLine($"{amount} ml su eklendi. Güncel su seviyesi {waterLevel} ml");
            }
        }
        public void AddCoffeeBeans(int amount)
        {
            if (amount > 0)
            {
                coffeeBeans += amount;
                Console.WriteLine($"{amount} gram kahve çekirdeği eklendi. Güncel kahve miktarı {coffeeBeans} gram");
            }
        }
    }
}
