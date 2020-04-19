﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Configuration
{
    public interface IAppConfig
    {
        int MaxTrys { get; }
        int SecondsToWait { get; }
        string ServiceUrl { get; }
       // int CacheExpireInMinutes { get; }
    }
}
