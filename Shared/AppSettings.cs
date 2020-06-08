using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorOnGitHubPages.Shared
{
    public class AppSettings
    {
        public Connectionstrings ConnectionStrings { get; set; }
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
        public Mlmodel MLModel { get; set; }
        public string AlphaVantageApiKey { get; set; }
        public string DeviceHubUrl { get; set; }
    }

    public class Connectionstrings
    {
        public string DefaultConnection { get; set; }
        public string AppConnection { get; set; }
    }

    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string Microsoft { get; set; }
        public string MicrosoftHostingLifetime { get; set; }
    }

    public class Mlmodel
    {
        public string MLModelFilePath { get; set; }
    }
}
