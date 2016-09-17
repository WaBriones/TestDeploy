using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.Configuration;

namespace CustomerSurvery.API.Helpers
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;
        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public string GetSetting(string key)
        {
            return _configuration.Get(key);
        }
    }
}
