//interface ornegi
using AbstractionInterfaceV;

public class Program
{
    public static void Main(string[] args)
    {
        //Circle circle = new Circle(7); // ctor prametresi girdik.
        //circle.Draw();
        //Console.WriteLine(circle.Area());

        //Rectangle rectangle = new Rectangle(100, 200);
        //rectangle.Draw();
        //Console.WriteLine(rectangle.Area());

        ////poly kullanımı
        //Ishape shape = new  Circle(4);
        //shape.Draw(); 
        //Console.WriteLine(shape.Area());  

        //__shape ıcın
        //Circle circle = new Circle(5);

        //Console.WriteLine(circle.Area()); 
        //___databese ıcın

        IDatabase db = new MsSQLDatabase();
        db.Connect();
        db.ExecuteQuery("select * from user");
        ((ICashe)db).Store("user", new { Name = "Murat" }); // Icashe den cagırdıgı ıcın db yı oradan tanımladık.
        ((ICashe)db).Retrieve("user");
        db.Disconnect();
        // veya db nesnesini ICache türünde tanımlayın:
        //ICashe cache = new MsSQLDatabase();
        //cache.Store("user", new { Name = "Murat" });
        ////cache.Retrieve("user");
    }
}