namespace MVCProject.Models
{
    public static class Data
    {
        //Id, AuthorId, Title, CopiesAvailable, ISBN, Genre ve PublishDate kıtap bılgılerı
        public static List<Book> Books { get; set; } = new List<Book>()
        {
            new Book() { Id = 1, AuthorId = 1, Title = "The Resilience Factor: 7 Keys to Finding Your Inner Strength and Overcoming Life's Hurdles", CopiesAvailable = 15, ISBN = "9780767911912", Genre = "Psychology", PublishDate = new DateTime(2002, 1, 1) },
            new Book() { Id = 2, AuthorId = 2, Title = "Resilience: The Science of Mastering Life's Greatest Challenges", CopiesAvailable = 12, ISBN = "9781462505372", Genre = "Psychology", PublishDate = new DateTime(2012, 1, 1) },
            new Book() { Id = 3, AuthorId = 3, Title = "Building Resilience in Children and Teens: Giving Kids Roots and Wings", CopiesAvailable = 10, ISBN = "9781611680844", Genre = "Psychology", PublishDate = new DateTime(2014, 1, 1) },
            new Book() { Id = 4, AuthorId = 4, Title = "The Road to Resilience", CopiesAvailable = 8, ISBN = "9781433829840", Genre = "Psychology", PublishDate = new DateTime(2014, 1, 1) },
            new Book() { Id = 5, AuthorId = 5, Title = "Resilience at Work: How to Succeed No Matter What Life Throws at You", CopiesAvailable = 7, ISBN = "9780470190532", Genre = "Psychology", PublishDate = new DateTime(2009, 1, 1) },
            new Book() { Id = 6, AuthorId = 6, Title = "The Power of Resilience: Achieving Balance, Confidence, and Personal Strength in Your Life", CopiesAvailable = 14, ISBN = "9780470148298", Genre = "Psychology", PublishDate = new DateTime(2011, 1, 1) },
            new Book() { Id = 7, AuthorId = 7, Title = "Resilience: Hard-Won Wisdom for Living a Better Life", CopiesAvailable = 6, ISBN = "9780544231434", Genre = "Psychology", PublishDate = new DateTime(2015, 1, 1) },
            new Book() { Id = 8, AuthorId = 8, Title = "Resilience and Mental Health: Challenges Across the Lifespan", CopiesAvailable = 9, ISBN = "9780415993969", Genre = "Psychology", PublishDate = new DateTime(2010, 1, 1) },
            new Book() { Id = 9, AuthorId = 9, Title = "The Psychology of Resilience: A Handbook of Theory and Practice", CopiesAvailable = 11, ISBN = "9780415405979", Genre = "Psychology", PublishDate = new DateTime(2008, 1, 1) },
            new Book() { Id = 10, AuthorId = 10, Title = "The Science of Resilience: How to Thrive in the Face of Adversity", CopiesAvailable = 5, ISBN = "9780465089771", Genre = "Psychology", PublishDate = new DateTime(2011, 1, 1) }
        };

        // yazar bilgileri
        public static List<Author> Authors { get; set; } = new List<Author>()
        {
            new Author { Id = 1, FirstName = "Karen", LastName = "Reivich", DateOfBirth = new DateTime(1963, 1, 1) },
            new Author { Id = 2, FirstName = "George", LastName = "Bonanno", DateOfBirth = new DateTime(1961, 1, 1) },
            new Author { Id = 3, FirstName = "Katherine", LastName = "Boyd", DateOfBirth = new DateTime(1975, 1, 1) },
            new Author { Id = 4, FirstName = "Albert", LastName = "Ellis", DateOfBirth = new DateTime(1913, 9, 27) },
            new Author { Id = 5, FirstName = "Robert", LastName = "Nisbet", DateOfBirth = new DateTime(1960, 1, 1) },
            new Author { Id = 6, FirstName = "Michael", LastName = "Benson", DateOfBirth = new DateTime(1955, 1, 1) },
            new Author { Id = 7, FirstName = "Terry", LastName = "Gillen", DateOfBirth = new DateTime(1965, 3, 15) },
            new Author { Id = 8, FirstName = "Ruth", LastName = "Scharf", DateOfBirth = new DateTime(1970, 1, 1) },
            new Author { Id = 9, FirstName = "Peter", LastName = "Henderson", DateOfBirth = new DateTime(1970, 5, 11) },
            new Author { Id = 10, FirstName = "Jared", LastName = "Harris", DateOfBirth = new DateTime(1980, 7, 25) }
        };



    }
}
