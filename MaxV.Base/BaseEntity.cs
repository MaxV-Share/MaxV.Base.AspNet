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
    public abstract class BaseEntity<TKey>
    {
        public virtual void SetDefaultValue(string createBy)
        {
            CreateAt = DateTime.Now;
            UpdateAt = CreateAt;
        }
        public virtual void SetValueUpdate(string updateBy)
        {
            UpdateAt = DateTime.Now;
            UpdateBy = updateBy;
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual TKey Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string Deleted { get; set; }
    }
}
