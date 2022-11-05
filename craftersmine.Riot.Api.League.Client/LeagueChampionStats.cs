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
        [JsonProperty("abilityHaste")]
        public double AbilityHaste { get; private set; }
        [JsonProperty("abilityPower")]
        public double AbilityPower { get; private set; }
        [JsonProperty("armor")]
        public double Armor { get; private set; }
        [JsonProperty("armorPenetrationFlat")]
        public double ArmorPenetrationFlat { get; private set; }
        [JsonProperty("armorPenetrationPercent")]
        public double ArmorPenetrationPercent { get; private set; }
        [JsonProperty("attackDamage")]
        public double AttackDamage { get; private set; }
        [JsonProperty("attackRange")]
        public double AttackRange { get; private set; }
        [JsonProperty("attackSpeed")]
        public double AttackSpeed { get; private set; }
        [JsonProperty("bonusArmorPenetrationPercent")]
        public double BonusArmorPenetrationPercent { get; private set; }
        [JsonProperty("bonusMagicPenetrationPercent")]
        public double BonusMagicPenetrationPercent { get; private set; }
        [JsonProperty("critChance")]
        public double CriticalStrikeChance { get; private set; }
        [JsonProperty("critDamage")]
        public double CriticalStrikeDamage { get; private set; }
        [JsonProperty("currentHealth")]
        public double CurrentHealth { get; private set; }
        [JsonProperty("resourceValue")]
        public double CurrentResourceValue { get; private set; }
        [JsonProperty("healShieldPower")]
        public double HealShieldPower { get; private set; }
        [JsonProperty("healthRegenerationRate")]
        public double HealthRegenerationRate { get; private set; }
        [JsonProperty("lifeSteal")]
        public double LifeSteal { get; private set; }
        [JsonProperty("magicLethality")]
        public double MagicLethality { get; private set; }
        [JsonProperty("magicPenetrationFlat")]
        public double MagicPenetrationFlat { get; private set; }
        [JsonProperty("magicPenetrationPercent")]
        public double MagicPenetrationPercent { get; private set; }
        [JsonProperty("magicResist")]
        public double MagicResistance { get; private set; }
        [JsonProperty("resourceMax")]
        public double MaxResource { get; private set; }
        [JsonProperty("maxHealth")]
        public double MaxHealth { get; private set; }
        [JsonProperty("moveSpeed")]
        public double MoveSpeed { get; private set; }
        [JsonProperty("omnivamp")]
        public double Omnivamp { get; private set; }
        [JsonProperty("physicalLethality")]
        public double PhysicalLethality { get; private set; }
        [JsonProperty("resourceRegenRate")]
        public double ResourceRegenerationRate { get; private set; }
        [JsonProperty("spellVamp")]
        public double SpellVamp { get; private set; }
        [JsonProperty("tenacity")]
        public double Tenacity { get; private set; }
        [JsonProperty("resourceType"), JsonConverter(typeof(StringEnumConverter))]
        public LeagueChampionResourceType ResourceType { get; private set; }
    }
}
