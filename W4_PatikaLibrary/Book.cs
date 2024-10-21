namespace W4_PatikaLibrary
{
    public class Book
    {
        private string title;
        private string authorFirstName;
        private string authorLastName;
        private int pageCount;
        private string publisher;
        private DateTime savedDate;

        // getters and setters
        public string Title { get { return title; } set { title = value; } }
        public string AuthorFirstName { get { return authorFirstName; } set { authorFirstName = value; } }
        public string AuthorLastName { get { return authorLastName; } set { authorLastName = value; } }
        public int PageCount { get { return pageCount; } set { pageCount = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public DateTime SavedDate { get { return savedDate; } set { savedDate = value; } }

        // default empty constructor
        public Book()
        {
            SavedDate = DateTime.Now;
        }

        // constructor with parameters
        public Book(string title, string authorFirstName, string authorLastName, int pageCount, string publisher)
        {
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            PageCount = pageCount;
            Publisher = publisher;
            SavedDate = DateTime.Now;
        }

        // method to print book details
        public void PrintBookDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {AuthorFirstName} {AuthorLastName}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Saved Date: {SavedDate.ToShortDateString()}");
        }
    }
}
