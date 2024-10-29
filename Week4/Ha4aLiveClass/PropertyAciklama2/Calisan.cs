using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAciklama2
{
    public class Calisan
    { 
        // Auto propety 
        public string Ad {  get; set; } //içinde fields var

        #region Full property

        //// Private alanlar (fields)
        //private string _ad;

        //public string Ad // Public property
        //{
        //    get { return _ad; }
        //    set { _ad = value; } // Eğer yalnızca okunabilir olsun istiyorsanız `set` kısmını kaldırabilirsiniz.
        //}

        #endregion

        private int _yas;
        public int Yas // yazdırmaya calısırsan get, deger atamaya calısırsan = ile, set çalışır ve o yazılır.. (programcs de acıklaması)
        {
            get
            {
                return _yas;
            }
            set
            {
                if (value < 0) // gelen deger 0dan kucukse
                    throw new Exception("Yaş negatif olamaz"); // yas 0dan kucukse (throw) ile yazmak hata fırlatır.
                _yas = value;
            }
        }
        public void KunyeYazdir()
        {
            Console.WriteLine($"{Ad} adlı çalışan {Yas} yaşındadır.");
        }
    }
}
// kısayollat
// prop [tab] auto property
// fullprop [tab] full property yazar. 

// Console.WriteLine($"{_ad} adlı çalışan {_yas} yaşındadır."); full property kullanırken {_ad} ile yazdık auto properyde hata verır.