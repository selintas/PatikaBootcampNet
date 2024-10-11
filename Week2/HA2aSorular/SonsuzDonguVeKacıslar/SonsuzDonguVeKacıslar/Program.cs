// Sürekli çift zar at 
// 6-6 gelise çık
  
Random rnd = new Random();
int a, b;

while (true)
{    
    a = rnd.Next(1, 7);
    b = rnd.Next(1, 7);
    Console.WriteLine("{0}-{1}", a,b); // 0 a gelir 1 e b gelir.

    Thread.Sleep(100); // 100ms uyut, donguyu yavaslatır. 
     
    if (a == 6 && b == 6)
        break;
}
Console.ReadKey();  