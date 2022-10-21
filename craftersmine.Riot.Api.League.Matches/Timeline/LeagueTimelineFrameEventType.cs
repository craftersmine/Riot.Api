using System;
using System.Collections.Generic;
using System.IO;
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
        PauseEnd,
        /// <summary>
        /// Champion skill leveled up
        /// </summary>
        SkillLevelUp,
        /// <summary>
        /// Item was purchased in item shop or crafted by Ornn
        /// </summary>
        ItemPurchased,
        /// <summary>
        /// Item was used or ward was placed
        /// </summary>
        ItemDestroyed,
        /// <summary>
        /// Item purchase undo
        /// </summary>
        ItemUndo,
        /// <summary>
        /// Item was sold
        /// </summary>
        ItemSold,
        /// <summary>
        /// Ward of any type was placed
        /// </summary>
        WardPlaced,
        /// <summary>
        /// Ward was destroyed (stealth, fairlight, control, etc.)
        /// </summary>
        WardKill,
        /// <summary>
        /// Champion leveled up
        /// </summary>
        LevelUp,
        /// <summary>
        /// Champion was killed
        /// </summary>
        ChampionKill,
        /// <summary>
        /// Special event happened when champion was killed (first blood, multi kill, etc.)
        /// </summary>
        ChampionSpecialKill,
        /// <summary>
        /// Elite monster were killed (dragon, rift herald, Baron Nashor, etc.)
        /// </summary>
        EliteMonsterKill,
        /// <summary>
        /// Turret plate was destroyed
        /// </summary>
        TurretPlateDestroyed,
        /// <summary>
        /// Building was destroyed (turret, inhibitor, nexus, etc)
        /// </summary>
        BuildingKill,
        /// <summary>
        /// Objective bounty starting
        /// </summary>
        ObjectiveBountyPrestart,
        /// <summary>
        /// Objective bounty ending
        /// </summary>
        ObjectiveBountyFinish,
        /// <summary>
        /// Dragon soul was obtained
        /// </summary>
        DragonSoulGiven,
        /// <summary>
        /// Game ended
        /// </summary>
        GameEnd,
        /// <summary>
        /// Champion is transformed (Kayn transformation)
        /// </summary>
        ChampionTransform,
        /// <summary>
        /// Unknown event type
        /// </summary>
        Unknown
    }

    /// <summary>
    /// Contains static extensions for <see cref="LeagueTimelineFrameEventType"/>
    /// </summary>
    public static class LeagueTimelineEventTypeExtensions
    {
        private const string PauseEnd = "PAUSE_END";
        private const string SkillLevelUp = "SKILL_LEVEL_UP";
        private const string ItemPurchased = "ITEM_PURCHASED";
        private const string ItemDestroyed = "ITEM_DESTROYED";
        private const string ItemUndo = "ITEM_UNDO";
        private const string ItemSold = "ITEM_SOLD";
        private const string WardPlaced = "WARD_PLACED";
        private const string WardKill = "WARD_KILL";
        private const string LevelUp = "LEVEL_UP";
        private const string ChampionKill = "CHAMPION_KILL";
        private const string ChampionSpecialKill = "CHAMPION_SPECIAL_KILL";
        private const string EliteMonsterKill = "ELITE_MONSTER_KILL";
        private const string TurretPlateDestroyed = "TURRET_PLATE_DESTROYED";
        private const string BuildingKill = "BUILDING_KILL";
        private const string ObjectiveBountyPrestart = "OBJECTIVE_BOUNTY_PRESTART";
        private const string ObjectiveBountyFinish = "OBJECTIVE_BOUNTY_FINISH";
        private const string DragonSoulGiven = "DRAGON_SOUL_GIVEN";
        private const string GameEnd = "GAME_END";
        private const string ChampionTranform = "CHAMPION_TRANSFORM";

        /// <summary>
        /// Gets a corresponding string for <see cref="LeagueTimelineFrameEventType"/>
        /// </summary>
        /// <param name="eventType">League of Legends match timeline frame event type value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="LeagueTimelineFrameEventType"/> value</returns>
        public static string GetStringForEventType(this LeagueTimelineFrameEventType eventType)
        {
            switch (eventType)
            {
                case LeagueTimelineFrameEventType.PauseEnd:
                    return PauseEnd;
                case LeagueTimelineFrameEventType.SkillLevelUp:
                    return SkillLevelUp;
                case LeagueTimelineFrameEventType.ItemPurchased:
                    return ItemPurchased;
                case LeagueTimelineFrameEventType.ItemDestroyed:
                    return ItemDestroyed;
                case LeagueTimelineFrameEventType.ItemUndo:
                    return ItemUndo;
                case LeagueTimelineFrameEventType.ItemSold:
                    return ItemSold;
                case LeagueTimelineFrameEventType.WardPlaced:
                    return WardPlaced;
                case LeagueTimelineFrameEventType.WardKill:
                    return WardKill;
                case LeagueTimelineFrameEventType.LevelUp:
                    return LevelUp;
                case LeagueTimelineFrameEventType.ChampionKill:
                    return ChampionKill;
                case LeagueTimelineFrameEventType.ChampionSpecialKill:
                    return ChampionSpecialKill;
                case LeagueTimelineFrameEventType.EliteMonsterKill:
                    return EliteMonsterKill;
                case LeagueTimelineFrameEventType.TurretPlateDestroyed:
                    return TurretPlateDestroyed;
                case LeagueTimelineFrameEventType.BuildingKill:
                    return BuildingKill;
                case LeagueTimelineFrameEventType.ObjectiveBountyPrestart:
                    return ObjectiveBountyPrestart;
                case LeagueTimelineFrameEventType.ObjectiveBountyFinish:
                    return ObjectiveBountyFinish;
                case LeagueTimelineFrameEventType.DragonSoulGiven:
                    return DragonSoulGiven;
                case LeagueTimelineFrameEventType.GameEnd:
                    return GameEnd;
                case LeagueTimelineFrameEventType.ChampionTransform:
                    return ChampionTranform;
                default:
                    throw new Exception("Unknown event type enum value, shouldn't happen");
            }
        }

        internal static LeagueTimelineFrameEventType GetLeagueTimelineFrameEventTypeFromString(this string str)
        {
            switch (str)
            {
                case PauseEnd:
                    return LeagueTimelineFrameEventType.PauseEnd;
                case SkillLevelUp:
                    return LeagueTimelineFrameEventType.SkillLevelUp;
                case ItemPurchased:
                    return LeagueTimelineFrameEventType.ItemPurchased;
                case ItemDestroyed:
                    return LeagueTimelineFrameEventType.ItemDestroyed;
                case ItemUndo:
                    return LeagueTimelineFrameEventType.ItemUndo;
                case ItemSold:
                    return LeagueTimelineFrameEventType.ItemSold;
                case WardPlaced:
                    return LeagueTimelineFrameEventType.WardPlaced;
                case WardKill:
                    return LeagueTimelineFrameEventType.WardKill;
                case LevelUp:
                    return LeagueTimelineFrameEventType.LevelUp;
                case ChampionKill:
                    return LeagueTimelineFrameEventType.ChampionKill;
                case ChampionSpecialKill:
                    return LeagueTimelineFrameEventType.ChampionSpecialKill;
                case EliteMonsterKill:
                    return LeagueTimelineFrameEventType.EliteMonsterKill;
                case TurretPlateDestroyed:
                    return LeagueTimelineFrameEventType.TurretPlateDestroyed;
                case BuildingKill:
                    return LeagueTimelineFrameEventType.BuildingKill;
                case ObjectiveBountyPrestart:
                    return LeagueTimelineFrameEventType.ObjectiveBountyPrestart;
                case ObjectiveBountyFinish:
                    return LeagueTimelineFrameEventType.ObjectiveBountyFinish;
                case DragonSoulGiven:
                    return LeagueTimelineFrameEventType.DragonSoulGiven;
                case GameEnd:
                    return LeagueTimelineFrameEventType.GameEnd;
                case ChampionTranform:
                    return LeagueTimelineFrameEventType.ChampionTransform;
                default:
                    //throw new ArgumentException("Unknown match timeline frame event type received! Value: " + str);
                    return LeagueTimelineFrameEventType.Unknown;
            }
        }
    }
}
