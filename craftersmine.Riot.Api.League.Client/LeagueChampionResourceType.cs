using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends champion resource type
    /// </summary>
    public enum LeagueChampionResourceType
    {
        /// <summary>
        /// Resource is mana
        /// </summary>
        Mana,
        /// <summary>
        /// Resource is ninja energy
        /// </summary>
        Energy,
        /// <summary>
        /// Champion has no resource
        /// </summary>
        None,
        /// <summary>
        /// Resource is health-shield (ex. Mordekaiser shield)
        /// </summary>
        Shield,
        /// <summary>
        /// Resource is battle-fury (ex. Tryndamere fury)
        /// </summary>
        BattleFury,
        /// <summary>
        /// Resource is dragon-fury (ex. Shyvana fury)
        /// </summary>
        DragonFury,
        /// <summary>
        /// Resource is rage
        /// </summary>
        Rage,
        /// <summary>
        /// Resource is heat (ex. Rumble heat)
        /// </summary>
        Heat,
        /// <summary>
        /// Resourece is Gnar fury
        /// </summary>
        GnarFury,
        /// <summary>
        /// Resource is ferocity (ex. Rengar ferocity)
        /// </summary>
        Ferocity,
        /// <summary>
        /// Resource is bloodwell (ex. Swain's blood well during ultimate)
        /// </summary>
        Bloodwell,
        /// <summary>
        /// Resource is flow (ex. Yasuo flow)
        /// </summary>
        Wind,
        /// <summary>
        /// Resource is ammunition (ex. Graves shotgun shells)
        /// </summary>
        Ammo,
        /// <summary>
        /// Resource is Aphelios ammo
        /// </summary>
        Moonlight,
        /// <summary>
        /// Resource is varied
        /// </summary>
        Other,
        /// <summary>
        /// Unknown resource value
        /// </summary>
        Max
    }
}
