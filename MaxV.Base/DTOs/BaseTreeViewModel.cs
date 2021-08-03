using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Base.DTOs
{
    public interface BaseTreeViewModel<T>
    {
        public T Data { get; set; }
        public List<BaseTreeViewModel<T>> Children { get; set; } 
    }
}
