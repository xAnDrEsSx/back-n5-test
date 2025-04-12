using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestN5.Domain.Entities.Common;

namespace TestN5.Domain.Entities
{
    [Table("permission_type")]
    public class PermissionType : BaseDomainModel
    {
        [Key]
        [Column("id")]
        [Comment("Unique ID for the requirement status")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("description", TypeName = "varchar(50)")]
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<Permission> Permissions { get; set; } = [];
    }
}
