using System;

namespace Root.Code.Framework.E01D
{
    public interface ApiResolverApi_I
    {
        TApi GetApi<TApi>();
        object GetApi(Type type);
    }
}
