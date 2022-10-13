﻿using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    public class Constants
    {
        #region Data Regions

        public const string BaseAddressRegionEurope  = "https://europe.api.riotgames.com/";
        public const string BaseAddressRegionAmerica = "https://americas.api.riotgames.com/";
        public const string BaseAddressRegionAsia    = "https://asia.api.riotgames.com/";
        public const string BaseAddressRegionEsports = "https://esports.api.riotgames.com/";
        public const string BaseAddressRegionSea     = "https://sea.api.riotgames.com/";

        #endregion

        #region Data Platforms
        
        public const string BaseAddressPlatformBr1  = "https://br1.api.riotgames.com/";
        public const string BaseAddressPlatformEun1 = "https://eun1.api.riotgames.com/";
        public const string BaseAddressPlatformEuw1 = "https://euw1.api.riotgames.com/";
        public const string BaseAddressPlatformJp1  = "https://jp1.api.riotgames.com/";
        public const string BaseAddressPlatformKr   = "https://kr.api.riotgames.com/";
        public const string BaseAddressPlatformLa1  = "https://la1.api.riotgames.com/";
        public const string BaseAddressPlatformLa2  = "https://la2.api.riotgames.com/";
        public const string BaseAddressPlatformNa1  = "https://na1.api.riotgames.com/";
        public const string BaseAddressPlatformOc1  = "https://oc1.api.riotgames.com/";
        public const string BaseAddressPlatformTr1  = "https://tr1.api.riotgames.com/";
        public const string BaseAddressPlatformRu   = "https://ru.api.riotgames.com/";

        #endregion

        #region Valorant Shards

        public const string ShardValorantEurope = "eu";
        public const string ShardValorantNorthAmerica = "na";
        public const string ShardValorantLatinAmerica = "latam";
        public const string ShardValorantKorea = "kr";
        public const string ShardValorantBrazil = "br";
        public const string ShardValorantAsiaPacific = "ap";

        #endregion

        #region LoR Shards

        public const string ShardLoREurope = "europe";
        public const string ShardLoRAmericas = "americas";
        public const string ShardLoRAsiaPacific = "apac";

        #endregion

        #region Shards Games

        public const string ShardGameLegendsOfRunterra = "lor";
        public const string ShardGameValorant = "val";

        #endregion
    }
}
