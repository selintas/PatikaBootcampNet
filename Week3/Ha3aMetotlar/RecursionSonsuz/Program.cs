// Recursıon sonsuz dongu ornegı

using System.Security;

void SaatiGoster()
{ 
    Console.Clear();
    Console.WriteLine(DateTime.Now.ToLongTimeString()); 
    Thread.Sleep(1000); // 1 Sanıye akışı uyut.
    SaatiGoster(); // kendını cağırıyor.(Sonsuz)
}

SaatiGoster();

Console.ReadKey();