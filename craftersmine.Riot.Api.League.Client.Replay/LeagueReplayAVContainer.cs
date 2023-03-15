using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace craftersmine.Riot.Api.League.Client.Replay
{
    public enum LeagueReplayAVContainer
    {
        WebM,
        Png,
        PngAndDepth
    }

    public static class LeagueReplayAvContainerExtensions
    {
        private const string WebM = "webm";
        private const string Png = "png";
        private const string PngAndDepth = "pngAndDepth";

        public static string GetReplayAvContainerString(this LeagueReplayAVContainer container)
        {
            switch (container)
            {
                case LeagueReplayAVContainer.WebM:
                    return WebM;
                case LeagueReplayAVContainer.Png:
                    return Png;
                case LeagueReplayAVContainer.PngAndDepth:
                    return PngAndDepth;
            }

            throw new ArgumentException("Invalid container value", nameof(container));
        }

        public static LeagueReplayAVContainer GetReplayAvContainerFromString(this string str)
        {
            switch (str)
            {
                case WebM:
                    return LeagueReplayAVContainer.WebM;
                case Png:
                    return LeagueReplayAVContainer.Png;
                case PngAndDepth:
                    return LeagueReplayAVContainer.PngAndDepth;
            }

            throw new ArgumentException("Invalid container value received!", nameof(str));
        }
    }
}
