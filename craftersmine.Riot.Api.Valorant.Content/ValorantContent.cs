using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.Valorant.Content
{
    /// <summary>
    /// Represents metadata about current Valorant content
    /// </summary>
    public class ValorantContent
    {
        /// <summary>
        /// Gets a version for which game version this data is valid
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; private set; }
        /// <summary>
        /// Gets an array of Valorant acts
        /// </summary>
        [JsonProperty("acts")]
        public ValorantAct[] Acts { get; private set; }
        /// <summary>
        /// Gets an array of Valorant match ending ceremonies
        /// </summary>
        [JsonProperty("ceremonies")]
        public ValorantContentItem[] Ceremonies { get; private set; }
        /// <summary>
        /// Gets an array of Valorant characters
        /// </summary>
        [JsonProperty("characters")]
        public ValorantContentItem[] Characters { get; private set; }
        /// <summary>
        /// Gets an array of Valorant gunbuddies (charms)
        /// </summary>
        [JsonProperty("charms")]
        public ValorantContentItem[] Charms { get; private set; }
        /// <summary>
        /// Gets an array of Valorant gunbuddies levels (charms levels)
        /// </summary>
        [JsonProperty("charmLevels")]
        public ValorantContentItem[] CharmsLevels { get; private set; }
        /// <summary>
        /// Gets an array of Valorant gun skins chormas
        /// </summary>
        [JsonProperty("chromas")]
        public ValorantContentItem[] Chromas { get; private set; }
        /// <summary>
        /// Gets an array of Valorant equips (guns, character weapons, etc)
        /// </summary>
        [JsonProperty("equips")]
        public ValorantContentItem[] Equips { get; private set; }
        /// <summary>
        /// Gets an array of Valorant gamemodes
        /// </summary>
        [JsonProperty("gameModes")]
        public ValorantContentItem[] GameModes { get; private set; }
        /// <summary>
        /// Gets an array of Valorant maps
        /// </summary>
        [JsonProperty("maps")]
        public ValorantContentItem[] Maps { get; private set; }
        /// <summary>
        /// Gets an array of Valorant player cards (banners)
        /// </summary>
        [JsonProperty("playerCards")]
        public ValorantContentItem[] PlayerCards { get; private set; }
        /// <summary>
        /// Gets an array of Valorant player titles
        /// </summary>
        [JsonProperty("playerTitles")]
        public ValorantContentItem[] PlayerTitles { get; private set; }
        /// <summary>
        /// Gets an array of Valorant gun skins
        /// </summary>
        [JsonProperty("skins")]
        public ValorantContentItem[] Skins { get; private set; }
        /// <summary>
        /// Gets an array of Valorant gun skins levels
        /// </summary>
        [JsonProperty("skinLevels")]
        public ValorantContentItem[] SkinLevels { get; private set; }
    }
}
