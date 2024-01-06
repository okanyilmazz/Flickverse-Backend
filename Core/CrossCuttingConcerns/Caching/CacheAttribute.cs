namespace Core.CrossCuttingConcerns.Cache;

public class CacheAttribute : Attribute
{

    public int Duration { get; }
    public CacheAttribute()
    {
    }

    public CacheAttribute(int duration)
    {
        Duration = duration;
    }
}
