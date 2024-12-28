using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapilacaklarUygulamasi.Data
{
    public class Gorev
    {
        public int Id { get; set; }

        //[MaxLength(400)]
        public string Baslik { get; set; } = "";

        public bool Yapildi { get; set; }
    }
}
