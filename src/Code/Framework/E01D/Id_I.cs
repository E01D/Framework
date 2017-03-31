namespace Root.Code.Framework.E01D
{
    public interface Id_I: Identifiable_I<long>
    {
        new long Id { get; set; }
    }
}
