using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Matches.Timeline
{
    /// <summary>
    /// Represents a League of Legends champion current stats
    /// </summary>
    public class LeagueChampionStats
    {
        /// <summary>
        /// Gets current ability haste value
        /// </summary>
        [JsonProperty("abilityHaste")]
        public int AbilityHaste { get; private set; }
        /// <summary>
        /// Gets current ability power (AP) value
        /// </summary>
        [JsonProperty("abilityPower")]
        public int AbilityPower { get; private set; }
        /// <summary>
        /// Gets current physical armor value
        /// </summary>
        [JsonProperty("armor")]
        public int Armor { get; private set; }
        /// <summary>
        /// Gets current physical armor penetration value
        /// </summary>
        [JsonProperty("armorPen")]
        public int ArmorPenetration { get; private set; }
        /// <summary>
        /// Gets current physical armor penetration percentage
        /// </summary>
        [JsonProperty("armorPenPercent")]
        public int ArmorPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current attack damage (AD) value
        /// </summary>
        [JsonProperty("attackDamage")]
        public int AttackDamage { get; private set; }
        /// <summary>
        /// Gets current attack speed value
        /// </summary>
        [JsonProperty("attackSpeed")]
        public int AttackSpeed { get; private set; }
        /// <summary>
        /// Gets current bonus physical armor penetration percentage
        /// </summary>
        [JsonProperty("bonusArmorPenPercent")]
        public int BonusArmorPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current bonus magic resistance penetration percentage
        /// </summary>
        [JsonProperty("bonusMagicPenPercent")]
        public int BonusMagicPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current tenacity (crowd-control status time reduction) value
        /// </summary>
        [JsonProperty("ccReduction")]
        public int Tenacity { get; private set; }
        /// <summary>
        /// Gets current spells cooldown reduction value
        /// </summary>
        [JsonProperty("cooldownReduction")]
        public int CooldownReduction { get; private set; }
        /// <summary>
        /// Gets current champion health value
        /// </summary>
        [JsonProperty("health")]
        public int Health { get; private set; }
        /// <summary>
        /// Gets maximum champion health value
        /// </summary>
        [JsonProperty("healthMax")]
        public int HealthMax { get; private set; }
        /// <summary>
        /// Gets champion health regeneration value per tick
        /// </summary>
        [JsonProperty("healthRegen")]
        public int HealthRegeneration { get; private set; }
        /// <summary>
        /// Gets current champion lifesteal value
        /// </summary>
        [JsonProperty("lifesteal")]
        public int Lifesteal { get; private set; }
        /// <summary>
        /// Gets current magic resistance penetration value
        /// </summary>
        [JsonProperty("magicPen")]
        public int MagicPenetration { get; private set; }
        /// <summary>
        /// Gets current magic resistance penetration value
        /// </summary>
        [JsonProperty("magicPenPercent")]
        public int MagicPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current magic resistance value
        /// </summary>
        [JsonProperty("magicResist")]
        public int MagicResistance { get; private set; }
        /// <summary>
        /// Gets current champion movement speed
        /// </summary>
        [JsonProperty("movementSpeed")]
        public int MovementSpeed { get; private set; }
        /// <summary>
        /// Gets current champion omnivamp value
        /// </summary>
        [JsonProperty("omnivamp")]
        public int Omnivamp { get; private set; }
        /// <summary>
        /// Gets current physical vampirism value
        /// </summary>
        [JsonProperty("physicalVamp")]
        public int PhysicalVamp { get; private set; }
        /// <summary>
        /// Gets current resource value (ex. mana, energy, etc.)
        /// </summary>
        [JsonProperty("power")]
        public int Resource { get; private set; }
        /// <summary>
        /// Gets champion resource regeneration value per tick
        /// </summary>
        [JsonProperty("powerRegen")]
        public int ResourceRegeneration { get; private set; }
        /// <summary>
        /// Gets current champion spell related vampirism value
        /// </summary>
        [JsonProperty("spellVamp")]
        public int SpellVamp { get; private set; }
    }
}
