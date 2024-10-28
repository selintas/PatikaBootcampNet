using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsFieldsMethodsVideoPractise2
{
    public class Product
    {
        private string name; //fields
        private double price;
        private int stock; 
         
        public string Name  //properties
        { 
           get { return name; } 
           set { name = value; }  
        }

        public double Price
        {
            get { return price; }
            set { if (value >= 0) { price = value; } }
        } 

        public int Stock
        {
            get { return stock; } 

            set  
            { 
                if(value >= 0)
                {  
                    stock = value;  
                }
              
            }
        }
         
        //metotlar
        public void DisplayProduct() 
        {
            Console.WriteLine($"Ürün {name}, Fiyat {price} Stock {stock}");
        }

        public void SellProduct(int quantity)
        {
            if (quantity > 0 &&  quantity <= stock)
            {
                stock -= quantity;
                Console.WriteLine($"{quantity} adet {name} satıldı. Kalan stok {stock}"); 
                
            }
            else
            {
                Console.WriteLine("Yetersiz stok");
            }

        }

        public void RestockProduct(int quantity)
        {
            if (quantity > 0)
            {
                stock += quantity;

                Console.WriteLine($"{quantity} adet {name} stoğa eklendi. Güncel stok miktarı {stock}");
            }
        }

    } 

}
