using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InheritanceV
{
    public abstract class Vehicle
    {
        public virtual void Drive() // buclass ı mıras aldıgında değiştirerek kulllanabılırsın.
        {
            Console.WriteLine("driving..");
        } 
        public sealed class Car : Vehicle //car classı mıras alınamaz sealed yazılınca
        {
            public override void Drive()
            {
                Console.WriteLine(" deriving car..");
            }
        }  
        public class Bus : Vehicle
        {
            public sealed override void Drive()
            {
                {
                    Console.WriteLine("bus");
                }
            }
        } 

        public class PublicBus : Bus
        {
           //public override void Drive()  
           // alamyız cunku bus clasında Drive motot sealed edildi.
        }

    }
}
