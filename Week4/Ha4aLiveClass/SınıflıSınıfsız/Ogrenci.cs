using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıflıSınıfsız
{
    public class Ogrenci //class
    { 
        private string _unvan = "öğrencimiz"; // field (alan)- get set olunca prperty - private ile new nesne oluşturamayız. - program clasında new eklenemez.
        public string Ad {  get; set; } //property
         
        public int Yas { get; set; } //property

        public void KunyeGoster() //methot
        {
            Console.WriteLine("{0} adlı {2} {1} yaşındadır.", Ad, Yas, _unvan); // 0 yerine ad 1 yerine yaz 2 yerıne unvan yazıldı virgilden sonra no ile sıralandı.
        }
    }
}
