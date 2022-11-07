using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace craftersmine.Riot.Api.League.Client
{
    /// <summary>
    /// Represents a League of Legends champion current stats
    /// </summary>
    public class LeagueChampionStats
    {
        /// <summary>
        /// Gets current champion ability haste
        /// </summary>
        [JsonProperty("abilityHaste")]
        public double AbilityHaste { get; private set; }
        /// <summary>
        /// Gets current champion ability power
        /// </summary>
        [JsonProperty("abilityPower")]
        public double AbilityPower { get; private set; }
        /// <summary>
        /// Gets current champion armor
        /// </summary>
        [JsonProperty("armor")]
        public double Armor { get; private set; }
        /// <summary>
        /// Gets current champion flat armor penetration
        /// </summary>
        [JsonProperty("armorPenetrationFlat")]
        public double ArmorPenetrationFlat { get; private set; }
        /// <summary>
        /// Gets current champion percent armor penetration
        /// </summary>
        [JsonProperty("armorPenetrationPercent")]
        public double ArmorPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current champion attack damage
        /// </summary>
        [JsonProperty("attackDamage")]
        public double AttackDamage { get; private set; }
        /// <summary>
        /// Gets current champion attack range
        /// </summary>
        [JsonProperty("attackRange")]
        public double AttackRange { get; private set; }
        /// <summary>
        /// Gets current champion attack speed
        /// </summary>
        [JsonProperty("attackSpeed")]
        public double AttackSpeed { get; private set; }
        /// <summary>
        /// Gets current champion bonus percent armor penetration
        /// </summary>
        [JsonProperty("bonusArmorPenetrationPercent")]
        public double BonusArmorPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current champion bonus percent magic penetration
        /// </summary>
        [JsonProperty("bonusMagicPenetrationPercent")]
        public double BonusMagicPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current champion critical strike chance
        /// </summary>
        [JsonProperty("critChance")]
        public double CriticalStrikeChance { get; private set; }
        /// <summary>
        /// Gets current champion critical strike damage
        /// </summary>
        [JsonProperty("critDamage")]
        public double CriticalStrikeDamage { get; private set; }
        /// <summary>
        /// Gets current champion health
        /// </summary>
        [JsonProperty("currentHealth")]
        public double CurrentHealth { get; private set; }
        /// <summary>
        /// Gets current champion resource value (mana, energy, etc.)
        /// </summary>
        [JsonProperty("resourceValue")]
        public double CurrentResourceValue { get; private set; }
        /// <summary>
        /// Gets current healing and shielding power
        /// </summary>
        [JsonProperty("healShieldPower")]
        public double HealShieldPower { get; private set; }
        /// <summary>
        /// Gets current champion health regeneration rate per tick
        /// </summary>
        [JsonProperty("healthRegenerationRate")]
        public double HealthRegenerationRate { get; private set; }
        /// <summary>
        /// Gets current champion life steal percentage
        /// </summary>
        [JsonProperty("lifeSteal")]
        public double LifeSteal { get; private set; }
        /// <summary>
        /// Gets current champion magic lethality
        /// </summary>
        [JsonProperty("magicLethality")]
        public double MagicLethality { get; private set; }
        /// <summary>
        /// Gets current champion flat magic penetration
        /// </summary>
        [JsonProperty("magicPenetrationFlat")]
        public double MagicPenetrationFlat { get; private set; }
        /// <summary>
        /// Gets current champion percent magic penetration
        /// </summary>
        [JsonProperty("magicPenetrationPercent")]
        public double MagicPenetrationPercent { get; private set; }
        /// <summary>
        /// Gets current champion magic resistance
        /// </summary>
        [JsonProperty("magicResist")]
        public double MagicResistance { get; private set; }
        /// <summary>
        /// Gets current champion resource maximum value
        /// </summary>
        [JsonProperty("resourceMax")]
        public double MaxResource { get; private set; }
        /// <summary>
        /// Gets current champion health maximum value
        /// </summary>
        [JsonProperty("maxHealth")]
        public double MaxHealth { get; private set; }
        /// <summary>
        /// Gets current champion move speed
        /// </summary>
        [JsonProperty("moveSpeed")]
        public double MoveSpeed { get; private set; }
        /// <summary>
        /// Gets current champion omnivamp percentage
        /// </summary>
        [JsonProperty("omnivamp")]
        public double Omnivamp { get; private set; }
        /// <summary>
        /// Gets current champion physical lethality
        /// </summary>
        [JsonProperty("physicalLethality")]
        public double PhysicalLethality { get; private set; }
        /// <summary>
        /// Gets current champion resource regeneration rate per tick
        /// </summary>
        [JsonProperty("resourceRegenRate")]
        public double ResourceRegenerationRate { get; private set; }
        /// <summary>
        /// Gets current champion spell vamp value
        /// </summary>
        [JsonProperty("spellVamp")]
        public double SpellVamp { get; private set; }
        /// <summary>
        /// Gets current champion tenacity
        /// </summary>
        [JsonProperty("tenacity")]
        public double Tenacity { get; private set; }
        /// <summary>
        /// Gets current champion resource type
        /// </summary>
        [JsonProperty("resourceType"), JsonConverter(typeof(StringEnumConverter))]
        public LeagueChampionResourceType ResourceType { get; private set; }
    }
}
