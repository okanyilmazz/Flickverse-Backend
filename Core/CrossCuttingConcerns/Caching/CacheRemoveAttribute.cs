namespace Core.CrossCuttingConcerns.Cache;

public class CacheRemoveAttribute : Attribute
{
    public string CacheType { get; }

    public CacheRemoveAttribute(string cacheType)
    {
        CacheType = cacheType;
    }
}
