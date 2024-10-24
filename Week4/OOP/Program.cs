using OOP;

public class Program
{
    public static void Main(string[] args)
    {
       // Robot robot = new Robot();
       // robot.name = "Robot 1";
       // robot.batteryLevel = 90;
       // robot.model = "K3";

       // robot.PerformTask("task1");
        
        // hero and monster

        GameCharacter hero = new GameCharacter();
        hero.name = "Hero";
        hero.health = 100;
        hero.strength = 20;
        hero.level = 1;
         
        GameCharacter monster = new GameCharacter();
        monster.name = "Monster";
        monster.health = 80;
        monster.strength = 15;
        monster.level = 1;


        hero.Attack(monster);
        monster.Attack(hero);

        hero.Heal(10);

        hero.LevelUp();

        hero.Attack(monster);


    }
}
