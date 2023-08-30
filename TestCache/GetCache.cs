using Microsoft.Extensions.Caching.Memory;
using System;

namespace TestCache
{
    public class GetCache:IGetCache
    {
        private readonly IMemoryCache _memory;
        public GetCache(IMemoryCache memory)
        {
            _memory = memory;
        }
        public string Get(string cachkey)
        {
            var result = _memory.Get(cachkey);
            return Convert.ToString(result);
        }
        public void Set(string key, object value, MemoryCacheEntryOptions options)
        {
            _memory.Set(key, value, options);
        }
    }
}
