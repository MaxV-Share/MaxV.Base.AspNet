namespace MaxV.Base.DTOs
{
    public abstract class BaseUpdateRequest<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}
