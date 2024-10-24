using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class GameCharacter 
    {
        public string name;
        public int health;
        public int strength;
        public int level;

        public void Attack(GameCharacter gameCharacter)
        {
            Console.WriteLine($"{name} adlı karakter {gameCharacter.name} adlı karaktere saldırdı.");
            gameCharacter.health -= strength;
            Console.WriteLine($"{gameCharacter.name} adlı karaktere {gameCharacter.health} sağlık değeri kaldı");
        }
        public void Heal(int amount)
        {  
            health += amount;
            Console.WriteLine($"{name} dlı karakterin toplam sağlık değeri {health} çıktı.");
        }
        public void LevelUp()
        {
            level++;
            strength += 10;
            Console.WriteLine($"{name}, {level} e atladı. Güç değeri {strength}");

        }
    }
}
