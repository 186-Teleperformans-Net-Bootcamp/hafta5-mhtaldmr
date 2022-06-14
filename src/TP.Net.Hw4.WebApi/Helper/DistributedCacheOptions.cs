﻿using Microsoft.Extensions.Caching.Distributed;

namespace TP.Net.Hw4.WebApi.Helper
{
    public class DistributedCacheOptions
    {
        public static DistributedCacheEntryOptions CacheOptions()
        {
            var cacheEntryOptions = new DistributedCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(3600));

                return cacheEntryOptions;
        }
    }
}
