using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Base.DTOs
{
    public class BaseViewModel<TKey>
    {
        public virtual TKey Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
