namespace Entities.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Author : CoreEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indicates we provide the Key, not the database
        public Guid AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomeState { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
