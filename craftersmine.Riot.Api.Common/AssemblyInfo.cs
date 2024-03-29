﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Tests")]

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Account")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Status")]

#region League

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Summoner")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.SummonerLeagues")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.ChampionRotations")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Mastery")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Clash")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Matches")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Matches.Timeline")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Challenges")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Tournament")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Spectator")]

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Client")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.League.Client.Replay")]

#endregion

#region Teamfight Tactics

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Tft.Summoner")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Tft.Leagues")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Tft.Matches")]

#endregion

#region Valorant

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Valorant.Content")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Valorant.Ranked")]

#endregion

#region Runeterra

[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Runeterra.Ranked")]
[assembly:InternalsVisibleTo("craftersmine.Riot.Api.Runeterra.Matches")]

#endregion