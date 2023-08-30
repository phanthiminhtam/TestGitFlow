using Microsoft.Extensions.Caching.Memory;

namespace TestCache
{
    public class CacheModel
    {
        private static IMemoryCache _memory;
        public CacheModel(IMemoryCache memory)
        {
            _memory = memory;
        }
        public static void Add(string key, string value)
        {
            var a = 5;
            var cachExprity = new MemoryCacheEntryOptions()
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(60),
                Priority = CacheItemPriority.High,
                SlidingExpiration = TimeSpan.FromSeconds(60),

            };
            _memory.Set(key, value, cachExprity);
        }
    }
}
