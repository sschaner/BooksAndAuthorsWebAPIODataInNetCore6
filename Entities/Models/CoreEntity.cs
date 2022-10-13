namespace Entities.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CoreEntity
    {
        public CoreEntity()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.ModifiedDate = DateTime.UtcNow;
        }

        public DateTimeOffset CreatedDate { get; set; }

        [ConcurrencyCheck]
        public DateTimeOffset ModifiedDate { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum length for CreatedBy is 100 characters.")]
        public string? CreatedBy { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum length for ModifiedBy is 100 characters.")]
        public string? ModifiedBy { get; set; }
    }
}
