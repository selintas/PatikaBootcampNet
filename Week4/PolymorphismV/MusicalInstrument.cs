using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismV
{
    public class MusicalInstrument
    { 
        public virtual void PlaySound() // metot değiştirilebilir
        {
            Console.WriteLine("playing sound");
        }
    } 
    public class Piano : MusicalInstrument
    {
        public override void PlaySound()
        { 
            //base.PlaySound(); vırtual metot dırekt alınabılır ve ek yazılabılır assagıdakı ile
            Console.WriteLine("piano sound");
        }
    }

    public class Guitar : MusicalInstrument
    {
        public override void PlaySound()
        {
            base.PlaySound(); // once bunu yazar sonra aşşağıdakini
            Console.WriteLine("guitar sound");
        }
    }
}
