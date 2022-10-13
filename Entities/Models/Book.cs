namespace Entities.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Book : CoreEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indicates we provide the Key, not the database
        public Guid BookId { get; set; }

        [ForeignKey("Author")]
        public Guid AuthorId { get; set; }

        public string Title { get; set; }

        public int PublishYear { get; set; }

        public int CopiesSold { get; set; }

        public Author? Authors { get; set; }
    }
}
