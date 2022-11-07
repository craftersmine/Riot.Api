using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends game event
    /// </summary>
    public enum LeagueGameEventType
    {
        /// <summary>
        /// Game has started
        /// </summary>
        GameStart,
        /// <summary>
        /// Minions started spawning
        /// </summary>
        MinionsSpawning,
        /// <summary>
        /// First kill made
        /// </summary>
        FirstBrick,
        /// <summary>
        /// Turret has been destroyed
        /// </summary>
        TurretKilled,
        /// <summary>
        /// Inhibitor has been destroyed
        /// </summary>
        InhibKilled,
        /// <summary>
        /// Dragon has been slain
        /// </summary>
        DragonKill,
        /// <summary>
        /// Herald has been slain
        /// </summary>
        HeraldKill,
        /// <summary>
        /// Baron has been slain
        /// </summary>
        BaronKill,
        /// <summary>
        /// Champion has been slain
        /// </summary>
        ChampionKill,
        /// <summary>
        /// Multikill has been performed
        /// </summary>
        Multikill,
        /// <summary>
        /// Team has been aced
        /// </summary>
        Ace
    }
}
