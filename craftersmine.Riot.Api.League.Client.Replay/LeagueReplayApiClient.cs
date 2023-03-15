using System;
using System.Threading.Tasks;
using craftersmine.Riot.Api.Common;
using craftersmine.Riot.Api.Common.Utils;

namespace craftersmine.Riot.Api.League.Client.Replay
{
    public class LeagueReplayApiClient : RiotApiClient
    {
        protected const string LeagueClientRoot = "https://localhost:2999/replay/";

        /// <summary>
        /// Creates a new instance of <see cref="LeagueReplayApiClient"/>
        /// </summary>
        /// <param name="settings">Settings for <see cref="LeagueReplayApiClient"/>. IgnoreSSLCertificates is required to be enabled!</param>
        public LeagueReplayApiClient(RiotApiClientSettings settings) : base(settings)
        { }

        public async Task<LeagueGameInfo> GetGameInfoAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "game");

            LeagueGameInfo gameInfo = await Client.GetAsync<LeagueGameInfo>(endpoint, null);
            return gameInfo;
        }

        public async Task<LeagueGameParticlesCollection> GetGameParticlesAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "particles");

            LeagueGameParticlesCollection particles =
                await Client.GetAsync<LeagueGameParticlesCollection>(endpoint, null);
            return particles;
        }

        public async Task<LeagueGameParticlesCollection> SetGameParticlesAsync(LeagueGameParticlesCollection particles)
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "particles");
            LeagueGameParticlesCollection ptcls = await Client.PostAsync<LeagueGameParticlesCollection>(endpoint, null, particles);
            return ptcls;
        }

        public async Task<bool> SetGameParticleVisibilityAsync(string particleId, bool visibilityValue)
        {
            LeagueGameParticlesCollection particles = await GetGameParticlesAsync();
            if (!particles.ContainsKey(particleId))
                throw new ArgumentException("Particle ID is not found in game!", nameof(particleId));

            particles[particleId] = visibilityValue;
            particles = await SetGameParticlesAsync(particles);
            return particles[particleId];
        }

        public async Task<bool> GetGameParticleVisibilityAsync(string particleId)
        {
            LeagueGameParticlesCollection particles = await GetGameParticlesAsync();
            if (!particles.ContainsKey(particleId))
                throw new ArgumentException("Particle ID is not found in game!", nameof(particleId));

            return particles[particleId];
        }

        public async Task<LeagueReplayPlaybackSettings> GetReplayPlaybackSettingsAsync()
        {
            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playback");

            LeagueReplayPlaybackSettings settings = await Client.GetAsync<LeagueReplayPlaybackSettings>(endpoint, null);
            return settings;
        }

        public async Task<LeagueReplayPlaybackSettings> SetReplayPlaybackSettingsAsync(
            LeagueReplayPlaybackSettings settings)
        {
            if (settings is null)
                throw new ArgumentNullException(nameof(settings));

            string endpoint = UriUtils.GetAddress(LeagueClientRoot, "playback");

            LeagueReplayPlaybackSettings settingsNew =
                await Client.PostAsync<LeagueReplayPlaybackSettings>(endpoint, null, settings);
            return settingsNew;
        }

        
    }
}
