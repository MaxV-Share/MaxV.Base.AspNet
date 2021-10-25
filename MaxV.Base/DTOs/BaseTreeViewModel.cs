using System.Collections.Generic;

namespace MaxV.Base.DTOs
{
    public interface BaseTreeViewModel<T>
    {
        public T Data { get; set; }
        public List<BaseTreeViewModel<T>> Children { get; set; }
    }
}
