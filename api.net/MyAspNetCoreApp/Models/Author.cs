namespace MyAspNetCoreApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // One-to-Many: Один автор — много книг
        public List<Book> Books { get; } = new();
    }
}