using AppData.Entity;

namespace AppData.Models
{
    public class ReviewEntity:BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime DateTime { get; set; }

        public string? Content { get; set; }

        public Guid? VirtualItemId { get; set; }

        public Guid IdAccount { get; set; }
    }
}
