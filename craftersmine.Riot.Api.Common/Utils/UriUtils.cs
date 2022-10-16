using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common.Utils
{
    internal static class UriUtils
    {
        public static string GetAddress(RiotPlatform platform, string endpoint)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentNullException(nameof(endpoint));

            if (endpoint.StartsWith("/"))
                endpoint = endpoint.Substring(1);

            return platform.GetAddressFor() + endpoint;
        }

        public static string GetAddress(RiotRegion region, string endpoint)
        {
            if (string.IsNullOrWhiteSpace(endpoint))
                throw new ArgumentNullException(nameof(endpoint));

            if (endpoint.StartsWith("/"))
                endpoint = endpoint.Substring(1);

            return region.GetAddressFor() + endpoint;
        }

        public static string JoinEndpoints(params string[] endpointsPaths)
        {
            string endpoint = string.Empty;
            foreach (string path in endpointsPaths)
            {
                string p = path.Trim();
                if (p.EndsWith("/"))
                    p = p.Substring(0, p.Length - 1);
                if (p.StartsWith("/"))
                    p = p.Substring(1);
                endpoint = string.Join("/", endpoint, p);
            }

            return endpoint;
        }
    }
}
