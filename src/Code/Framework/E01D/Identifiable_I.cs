namespace Root.Code.Framework.E01D
{
    public interface Identifiable_I<out TKey>
    {
        TKey Id { get; }
    }
}
