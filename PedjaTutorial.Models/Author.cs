namespace PedjaTutorial.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string UniqueIndentifier { get; set; }

        public List<Book> Books { get; set; }
    }
}