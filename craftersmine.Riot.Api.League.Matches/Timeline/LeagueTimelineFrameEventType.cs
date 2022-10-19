using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends match timeline frame event type
    /// </summary>
    public enum LeagueTimelineFrameEventType
    {
        /// <summary>
        /// The game has been resumed
        /// </summary>
        ///
        /// PAUSE_END
        PauseEnd,
        /// <summary>
        /// Champion skill leveled up
        /// </summary>
        ///
        /// SKILL_LEVEL_UP
        SkillLevelUp,
        /// <summary>
        /// Item was purchased in item shop or crafted by Ornn
        /// </summary>
        ///
        /// ITEM_PURCHASED
        ItemPurchased,
        /// <summary>
        /// Ward of any type was placed
        /// </summary>
        ///
        /// WARD_PLACED
        WardPlaced,
        /// <summary>
        /// Champion leveled up
        /// </summary>
        ///
        /// LEVEL_UP
        LevelUp,
        /// <summary>
        /// Item was used or ward was placed
        /// </summary>
        ///
        /// ITEM_DESTROYED
        ItemDestroyed,
        /// <summary>
        /// Champion was killed
        /// </summary>
        ///
        /// CHAMPION_KILL
        ChampionKill,
        /// <summary>
        /// Special event happened when champion was killed (first blood, multi kill, etc.)
        /// </summary>
        ///
        /// CHAMPION_SPECIAL_KILL
        ChampionSpecialKill,
        /// <summary>
        /// Item purchase undo
        /// </summary>
        ///
        /// ITEM_UNDO
        ItemUndo,
        /// <summary>
        /// Item was sold
        /// </summary>
        ///
        /// ITEM_SOLD
        ItemSold,
        /// <summary>
        /// Elite monster were killed (dragon, rift herald, Baron Nashor, etc.)
        /// </summary>
        ///
        /// ELITE_MONSTER_KILL
        EliteMonsterKill,
        /// <summary>
        /// Turret plate was destroyed
        /// </summary>
        ///
        /// TURRET_PLATE_DESTROYED
        TurretPlateDestroyed,
        /// <summary>
        /// Ward was destroyed (stealth, fairlight, control, etc.)
        /// </summary>
        ///
        /// WARD_KILL
        WardKill,
        /// <summary>
        /// Building was destroyed (turret, inhibitor, nexus, etc)
        /// </summary>
        ///
        /// BUILDING_KILL
        BuildingKill,
        /// <summary>
        /// Objective bounty starting
        /// </summary>
        /// 
        /// OBJECTIVE_BOUNTY_PRESTART
        ObjectiveBountyPrestart,
        /// <summary>
        /// Dragon soul was obtained
        /// </summary>
        ///
        /// DRAGON_SOUL_GIVEN
        DragonSoulGiven,
        /// <summary>
        /// Game ended
        /// </summary>
        ///
        /// GAME_END
        GameEnd
    }
}
