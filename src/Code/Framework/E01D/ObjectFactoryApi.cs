namespace Root.Code.Framework.E01D
{
    public class ObjectFactoryApi: ObjectFactoryApi_I
    {
        public T Create<T>() where T : new()
        {
            return new T();
        }
    }
}
