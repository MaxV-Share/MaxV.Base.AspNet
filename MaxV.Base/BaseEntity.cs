using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaxV.Base
{
    [Microsoft.EntityFrameworkCore.Index(nameof(Id))]
    public class BaseEntity<TKey>
    {
        public static void SetDefaultValue<T>(ref T entity) where T: BaseEntity<TKey>
        {
            entity.Uuid = Guid.NewGuid();
            entity.CreateAt = DateTime.UtcNow;
            entity.UpdateAt = entity.CreateAt;

        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public TKey Id { get; set; }
        public Guid Uuid { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string Deleted { get; set; }
    }
}
