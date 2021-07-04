using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Base.DTOs
{
    public class BaseDTO<TKey> where TKey : struct
    {
        public TKey? Id { get; set; }
        public Guid? Uuid { get; set; }
    }
}
