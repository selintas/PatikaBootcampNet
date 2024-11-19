using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikPatikafyMüzikPlatform
{
    public class Singer
    {
        public string Name { get; set; }
        public string MusicGenre { get; set; }
        public int DebutYear { get; set; }
        public int AlbumSales { get; set; } // Albüm satışları milyon cinsinden sayıya çevrildi

        public override string ToString()
        {
            return $"{Name} - {MusicGenre} - {DebutYear} - {AlbumSales} milyon";
        }
    }
}
   