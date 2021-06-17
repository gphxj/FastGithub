﻿using System;

namespace FastGithub.Scanner
{
    [Options("Github")]
    sealed class GithubOptions
    {
        public ScanSetting Scan { get; set; } = new ScanSetting();

        public RemoteAddressProviderSetting RemoteAddressProvider { get; set; } = new RemoteAddressProviderSetting();

        public LocalAddressProviderSetting LocalAddressProvider { get; set; } = new LocalAddressProviderSetting();

        public class ScanSetting
        {
            public TimeSpan FullScanInterval = TimeSpan.FromHours(2d);

            public TimeSpan ResultScanInterval = TimeSpan.FromMinutes(1d);

            public TimeSpan TcpScanTimeout { get; set; } = TimeSpan.FromSeconds(1d);

            public TimeSpan HttpsScanTimeout { get; set; } = TimeSpan.FromSeconds(2d);
        }


        public class RemoteAddressProviderSetting
        {
            public bool Enable { get; set; } = true;

            public Uri MetaUri { get; set; } = new Uri("https://gitee.com/jiulang/fast-github/raw/master/FastGithub/meta.json");
        }

        public class LocalAddressProviderSetting
        {
            public bool Enable { get; set; } = true;

            public string IPRangeFilePath { get; set; } = "./IPRange.json";
        }
    }
}
