// where metodu kulllanımı

using LinqBasicQueryV;
using System.Collections.Concurrent;
using System.Net.Cache;

List<int> numbers = new List<int> { -2, -1, 0, 1, 5, 3, 4, 2 };

//0 dan buyuk olanlar 
var positiveNumbers = numbers.Where(num => num > 0).ToList(); // toLİst metodu eklemek metodun oz kulllanabılme ekler.

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("_____");
// select  list içincekı belırlı oz kullanmak ıcın girdi alınır istenılen cıkar.

var squaredNumbers = numbers.Select(num => num * num);
foreach (var number in squaredNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("_____");
// person clasına bak.
var personList  = numbers.Select(num => new Person { Id = num });
foreach (var person in personList)
{ Console.WriteLine(person); }

Console.WriteLine("_____");

// sıralama orderby
IEnumerable<int> sortedNumbers = numbers.OrderBy(num => num);

foreach (var number in sortedNumbers)
    { Console.WriteLine(number); }
Console.WriteLine("_____");

// sıralama orderbyDesc terse 
IEnumerable<int> sortedNumbersDesc = numbers.OrderByDescending(num => num);

foreach (var number in sortedNumbers)
{ Console.WriteLine(number); }
Console.WriteLine("_____");

//person list sıralam
var personListAsc = personList.OrderBy(person => person);
foreach (var person in personListAsc)
    { Console.WriteLine(person); }
Console.WriteLine("_____");

// person sınıfı ekle
List<Person> people = new List<Person>();
people.Add(new Person { Age = 25, Name = "Mehmet" });
people.Add(new Person { Age = 25, Name = "Ahmet" });
people.Add(new Person { Age = 15, Name = "Zeynep" });
people.Add(new Person { Age = 30, Name = "Ali" });

var sortedPeople = people.OrderBy(person => person.Age) 
                         .ThenBy(person => person.Name); // ordrby sonrası thenby ile sıralanır.

foreach (var person in sortedPeople)
{ Console.WriteLine($"ad: {person.Name} yaş: {person.Age}"); }

Console.WriteLine("_____");

// kıtap list 
List<Book> books = new List<Book>()
{
    new Book { Title = "Kitap 1", Year = 2000,},

    new Book { Title = "Kitap 2", Year = 2000,},

    new Book { Title = "Kitap 3", Year = 2010,},

    new Book { Title = "Kitap 4", Year = 2010,},

    new Book { Title = "Kitap 5", Year = 2008,}
};
// groupby gruplara göre sıralama
var GroupedByYear = books.GroupBy(book => book.Year);

foreach (var group in GroupedByYear)
{
    Console.WriteLine($"{group.Key}"); 
     
    foreach (var book in group)
    { Console.WriteLine($"{book.Title}"); }
}