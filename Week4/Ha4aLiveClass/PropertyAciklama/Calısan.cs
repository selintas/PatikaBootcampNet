using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAciklama
{ 
    // PROPERTY KULLANMADAN YAPALIM
    public class Calısan
    {
        public string Ad; //fields

        public int Yas; // fields 

        public void KunyeYazdır()
        {
            Console.WriteLine(" {0} adlı çalışan {1} yaşındadır.", Ad, Yas); // 0 a ad 1 e yas yazılacak deneek , den sonrası.
        }
    }
}
