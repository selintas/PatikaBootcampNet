
using Static;

public class Program
{
    public static void Main(string[] args)
    {
        RobotS robots = new RobotS("Robot", "K3", 77);
        RobotS.RobotCount++;

        RobotS rabot1 = new RobotS();
        RobotS.RobotCount++;


        RobotS.DisplayRobotCount();

    }
}
// new ornek üyeler her nesneye ozgdur.  
 
// static sınıfın kendısıne iaittir ve tum nesneler tarafından kulanılır sınıf duzeyınde temsil eder.