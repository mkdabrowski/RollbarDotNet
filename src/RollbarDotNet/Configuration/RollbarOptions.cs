﻿namespace RollbarDotNet.Configuration
{
    public class RollbarOptions
    {
        public string AccessToken { get; set; }

        public string Environment { get; set; }

        public BlacklistConfiguration Blacklist { get; set; }
    }
}
