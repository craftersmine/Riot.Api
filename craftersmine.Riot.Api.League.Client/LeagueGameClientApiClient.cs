using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends game client API client
    /// </summary>
    public class LeagueGameClientApiClient : RiotApiClient
    {
        protected const string LeagueClientRoot = "https://localhost:2999/liveclientdata/";

        /// <summary>
        /// Creates a new instance of <see cref="LeagueGameClientApiClient"/>
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueGameClientApiClient"/>. IgnoreSSLCertificates is required to be enabled!</param>
        public LeagueGameClientApiClient(RiotApiClientSettings settings) : base(settings) { }

        /// <summary>
        /// Requests all information about current game
        /// </summary>
        /// <returns>Current game information</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueGameData> GetAllGameDataAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "allgamedata");

            LeagueGameData gameData = await Client.GetAsync<LeagueGameData>(endpoint, null);
            return gameData;
        }

        /// <summary>
        /// Gets current active player data. Values are null and empty if you are spectating game
        /// </summary>
        /// <returns>Current active player data</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueActivePlayerData> GetActivePlayerDataAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "activeplayer");

            LeagueActivePlayerData activePlayerData = await Client.GetAsync<LeagueActivePlayerData>(endpoint, null);
            return activePlayerData;
        }

        /// <summary>
        /// Gets current active player summoner name
        /// </summary>
        /// <returns><see cref="string"/> with current player summoner name</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<string> GetActivePlayerNameAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "activeplayername");

            string name = await Client.GetAsync<string>(endpoint, null);
            return name;
        }

        /// <summary>
        /// Gets current active player champion abilities
        /// </summary>
        /// <returns>Champion abilities information of current player</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionAbilities> GetActivePlayerAbilitiesAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "activeplayerabilities");
            LeagueChampionAbilities abilities = await Client.GetAsync<LeagueChampionAbilities>(endpoint, null);

            return abilities;
        }

        /// <summary>
        /// Gets current active player champion runes
        /// </summary>
        /// <returns>Current player champion runes information</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionRunes> GetActivePlayerRunesAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "activeplayerrunes");

            LeagueChampionRunes runes = await Client.GetAsync<LeagueChampionRunes>(endpoint, null);
            return runes;
        }

        /// <summary>
        /// Gets current game players information
        /// </summary>
        /// <returns></returns>
        public async Task<LeaguePlayerData[]> GetPlayersDataAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playerlist");

            LeaguePlayerData[] playersData = await Client.GetAsync<LeaguePlayerData[]>(endpoint, null);
            return playersData;
        }

        /// <summary>
        /// Gets player scores (ex. K/D/A) by summoner name
        /// </summary>
        /// <param name="summonerName">Player's summoner name</param>
        /// <returns>Player game scores</returns>
        /// <exception cref="ArgumentNullException">When summoner name is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueScores> GetPlayerScoresAsync(string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playerscores");
            LeagueScores scores = await Client.GetAsync<LeagueScores>(endpoint,
                new Dictionary<string, object>() {{"summonerName", summonerName}});
            return scores;
        }

        /// <summary>
        /// Gets player summoner spells by summoner name
        /// </summary>
        /// <param name="summonerName">Player's summoner name</param>
        /// <returns>Player summoner spells</returns>
        /// <exception cref="ArgumentNullException">When summoner name is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeaguePlayerSummonerSpells> GetPlayerSummonerSpellsAsync(string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playersummonerspells");
            LeaguePlayerSummonerSpells spells = await Client.GetAsync<LeaguePlayerSummonerSpells>(endpoint,
                new Dictionary<string, object>() {{"summonerName", summonerName}});

            return spells;
        }

        /// <summary>
        /// Gets player main runes by summoner name
        /// </summary>
        /// <param name="summonerName">Player's summoner name</param>
        /// <returns>Player summoner main runes</returns>
        /// <exception cref="ArgumentNullException">When summoner name is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueChampionRunes> GetPlayerMainRunesAsync(string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playermainrunes");
            LeagueChampionRunes runes = await Client.GetAsync<LeagueChampionRunes>(endpoint,
                new Dictionary<string, object>() {{"summonerName", summonerName}});

            return runes;
        }

        /// <summary>
        /// Gets player's champion current items by summoner name
        /// </summary>
        /// <param name="summonerName">Player summoner name</param>
        /// <returns>An array of <see cref="LeagueItem"/> of champion</returns>
        /// <exception cref="ArgumentNullException">When summoner name is null or empty</exception>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueItem[]> GetPlayerItemsAsync(string summonerName)
        {
            if (string.IsNullOrWhiteSpace(summonerName))
                throw new ArgumentNullException(nameof(summonerName));

            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playeritems");
            LeagueItem[] items = await Client.GetAsync<LeagueItem[]>(endpoint,
                new Dictionary<string, object>() {{"summonerName", summonerName}});

            return items;
        }

        /// <summary>
        /// Gets current game events information
        /// </summary>
        /// <returns>Game events object</returns>
        /// <exception cref="craftersmine.Riot.Api.Common.Exceptions.RiotApiException">When Riot API request fails</exception>
        public async Task<LeagueGameEvents> GetGameEventsAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "eventdata");
            LeagueGameEvents events = await Client.GetAsync<LeagueGameEvents>(endpoint, null);

            return events;
        }

        /// <summary>
        /// Gets current game information (map, mode, etc.)
        /// </summary>
        /// <returns>Information about game</returns>
        public async Task<LeagueGameData> GetGameInfoAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "gamestats");
            LeagueGameData data = await Client.GetAsync<LeagueGameData>(endpoint, null);

            return data;
        }
    }
}
