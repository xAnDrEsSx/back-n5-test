using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TestN5.Domain.Entities.Common;

namespace TestN5.Domain.Entities
{
    [Table("users")]
    public class User : BaseDomainModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "uniqueidentifier")]
        public Guid Id { get; set; }

        [Column("document_number", TypeName = "varchar(20)")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Column("name", TypeName = "varchar(50)")]
        public string Name { get; set; } = string.Empty;

        [Column("last_name", TypeName = "varchar(50)")]
        public string LastName { get; set; } = string.Empty;

        [Column("email", TypeName = "varchar(60)")]
        public string Email { get; set; } = string.Empty;

        [Column("is_active")]
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Permission> Permissions { get; set; } = [];

    }
}
