using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Base.DTOs
{
    public class BaseDTOUpdateRequest<TKey>
    {
        public virtual TKey Id { get; set; }
        public Guid? Uuid { get; set; }
    }
}
