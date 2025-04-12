using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestN5.Domain.Entities.Common;

namespace TestN5.Domain.Entities
{
    [Table("permission")]
    public class Permission : BaseDomainModel
    {
        [Key]
        [Column("id", TypeName = "uniqueidentifier")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Unique identifier for the permission")]
        public Guid Id { get; set; }

        // Foreign key to User
        [ForeignKey("User")]
        [Column("user_id", TypeName = "uniqueidentifier")]
        public Guid UserId { get; set; }

        [ForeignKey("PermissionType")]
        [Column("permission_type_id", TypeName = "int")]
        public int PermissionTypeId { get; set; }

        [Column("permission_date", TypeName = "datetime")]
        public DateTime PermissionDate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual PermissionType PermissionType { get; set; } = null!;

    }
}
