// Fifo lifo gibi eklemek cıkarmak için

Queue<string> queue = new Queue<string>();

queue.Enqueue("Ali");
queue.Enqueue("Ayşe");
queue.Enqueue("Mehmet"); 
// bilet sırası olusturduk 

string firstPerson = queue.Dequeue(); // dequeue cıkarmak ıcın kullanılır. fifo ali cıkcak

Console.WriteLine($"ilk bilet sahini {firstPerson}"); // ali çıkcak

// sırdakı ilk elemanı cıkarma işlemı yapmadan erişim
//peek()
 string nextPerson = queue.Peek();
Console.WriteLine($"Sıradakı kısı goster: {nextPerson}");

Console.WriteLine("___"); 

// kuyrktakı kişiler

foreach(string item in queue)
{
    Console.WriteLine(item); 
}

// stack
// lifo son cıkar 
Stack<string> menu = new Stack<string>();

menu.Push("adım murat");
menu.Push("bugun salı gunu");
menu.Push("bugun  gunlerden carsamba"); // eklemek için push metodu kullanır 

menu.Pop(); 
 
menu.Peek(); 
 
foreach(string item in menu)
{
    Console.WriteLine(item);
}
