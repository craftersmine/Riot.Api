namespace craftersmine.Riot.Api.League.Matches.Timeline.FrameEvents
{
    /// <summary>
    /// Represents a League of Legends elite monster subtype
    /// </summary>
    public enum EliteMonsterSubtype
    {
        /// <summary>
        /// Elite monster has no subtype or subtype is unknown
        /// </summary>
        None,
        /// <summary>
        /// Elite monster is an Air Dragon
        /// </summary>
        DragonAir,
        /// <summary>
        /// Elite monster is an Mountain Dragon
        /// </summary>
        DragonEarth,
        /// <summary>
        /// Elite monster is a Fire Dragon
        /// </summary>
        DragonFire,
        /// <summary>
        /// Elite monster is a Sea Dragon
        /// </summary>
        DragonSea,
        /// <summary>
        /// Elite monster is a Hextech Dragon
        /// </summary>
        DragonHextech,
        /// <summary>
        /// Elite monster is a Chemtech Dragon
        /// </summary>
        DragonChemtech
    }

    /// <summary>
    /// Contains static extension methods for <see cref="EliteMonsterSubtype"/>
    /// </summary>
    public static class EliteMonsterSubtypeExtensions
    {
        private const string DragonAir = "AIR_DRAGON";
        private const string DragonEarth = "EARTH_DRAGON";
        private const string DragonFire = "FIRE_DRAGON";
        private const string DragonSea = "WATER_DRAGON";
        private const string DragonHextech = "HEXTECH_DRAGON";
        private const string DragonChemtech = "CHEMTECH_DRAGON";

        /// <summary>
        /// Gets a corresponding string for <see cref="EliteMonsterSubtype"/>
        /// </summary>
        /// <param name="eliteMonsterSubtype">A League of Legends <see cref="EliteMonsterSubtype"/> value</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="EliteMonsterSubtype"/> value</returns>
        public static string GetStringFor(this EliteMonsterSubtype eliteMonsterSubtype)
        {
            switch (eliteMonsterSubtype)
            {
                case EliteMonsterSubtype.DragonAir:
                    return DragonAir;
                case EliteMonsterSubtype.DragonEarth:
                    return DragonEarth;
                case EliteMonsterSubtype.DragonFire:
                    return DragonFire;
                case EliteMonsterSubtype.DragonSea:
                    return DragonSea;
                case EliteMonsterSubtype.DragonHextech:
                    return DragonHextech;
                case EliteMonsterSubtype.DragonChemtech:
                    return DragonChemtech;
                case EliteMonsterSubtype.None:
                default:
                    return string.Empty;
            }
        }

        internal static EliteMonsterSubtype GetEliteMonsterSubtypeFromString(this string str)
        {
            switch (str)
            {
                case DragonAir:
                    return EliteMonsterSubtype.DragonAir;
                case DragonEarth:
                    return EliteMonsterSubtype.DragonEarth;
                case DragonFire:
                    return EliteMonsterSubtype.DragonFire;
                case DragonSea:
                    return EliteMonsterSubtype.DragonSea;
                case DragonHextech:
                    return EliteMonsterSubtype.DragonHextech;
                case DragonChemtech:
                    return EliteMonsterSubtype.DragonChemtech;
                default:
                    return EliteMonsterSubtype.None;
            }
        }
    }
}
