using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public class RiotApiClient
    {
        private Client _client;
        private RiotApiClientSettings _settings;

        public RiotApiClient(RiotApiClientSettings settings)
        {
            _client = new Client();
        }
    }
}
