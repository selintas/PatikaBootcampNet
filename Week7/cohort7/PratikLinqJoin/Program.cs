using PratikLinqJoin;

namespace PratikLinqJoin
{
    //public class Author
    //{
    //    public int AuthorId { get; set; }
    //    public string Name { get; set; }
    //}

    //public class Book
    //{
    //    public int BookId { get; set; }
    //    public string Title { get; set; }
    //    public int AuthorId { get; set; }
    //} 
    class Program
    {
        static void Main(string[] args)
        {
            // Yazar verileri
            List<Author> authors = new List<Author>
            {
            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Şafak" },
            new Author { AuthorId = 3, Name = "Ahmet Ümit" }
            };

            // Kitap verileri
            List<Book> books = new List<Book>
            {
            new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
            new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
            new Book { BookId = 3, Title = "10 Min..", AuthorId = 2 },
            new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
            };

            // LINQ ile birleştirme işlemi
            var query = from book in books
                        join author in authors
                        on book.AuthorId equals author.AuthorId
                        select new { book.Title, author.Name };

            // Sonuçları ekrana yazdırma
            Console.WriteLine("Kitaplar ve Yazarları:");
            foreach (var item in query)
            {
                Console.WriteLine($"Kitap: {item.Title}, Yazar: {item.Name}");
            }
        }
    
    }
}


