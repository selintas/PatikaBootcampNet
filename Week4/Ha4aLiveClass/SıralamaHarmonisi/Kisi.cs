using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıralamaHarmonisi
{
    public class Kisi
    {
        public string Ad {  get; set; }
        public int Yas { get; set; }

        public string Ozet()
        {  
            return $"{Ad} ({Yas})";  
        }
    }
}
