﻿using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceColletion)
        {
            serviceColletion.AddMemoryCache();
            serviceColletion.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceColletion.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceColletion.AddSingleton<Stopwatch>();
        }
    }
}
