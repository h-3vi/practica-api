using System.ComponentModel.DataAnnotations.Schema;

namespace MyAspNetCoreApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int AuthorId { get; set; }

        public Author Author { get; set; } = null!;

        // Many-to-Many: без промежуточной сущности
        public List<Genre> Genres { get; set; } = new();
    }
}