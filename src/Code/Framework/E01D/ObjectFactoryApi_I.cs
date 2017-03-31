namespace Root.Code.Framework.E01D
{
    public interface ObjectFactoryApi_I
    {
        T Create<T>()
            where T : new();
    }
}
