using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Base.DTOs
{
    public class BaseUpdateRequest<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}
