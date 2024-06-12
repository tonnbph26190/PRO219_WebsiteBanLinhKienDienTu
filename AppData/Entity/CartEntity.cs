using AppData.Entity;
using System.ComponentModel.DataAnnotations;

namespace AppData.Models
{
    public class CartEntity:BaseEntity
    {
        public Guid Id { get; set; }
        public Guid? IdAccount { get; set; }
        public string UserName { get; set; }
        public string? Description { get; set; }
        public virtual AccountEntity? Accounts { get; set; }
        public virtual List< CartDetailsEntity>? CartDetails{ get; set; }
    }
}
