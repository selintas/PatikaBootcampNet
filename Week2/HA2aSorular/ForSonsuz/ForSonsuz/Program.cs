// saat sonsuz dongu 
for (; ; ) //while(true) veya while(1 < 2) sonsuz dongu yapar.

{
    Console.Clear(); // her degısımde temızler alt alta devam etmez.
    Console.WriteLine(DateTime.Now.ToLongTimeString());
    Thread.Sleep(1000);
}
