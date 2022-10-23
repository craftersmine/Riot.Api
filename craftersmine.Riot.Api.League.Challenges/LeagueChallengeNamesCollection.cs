using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using craftersmine.Riot.Api.Common.Converters;
using Newtonsoft.Json;

namespace craftersmine.Riot.Api.League.Challenges
{
    /// <summary>
    /// Represents a collection of League of Legends challenge localized names and descriptions
    /// </summary>
    public class LeagueChallengeNamesCollection : Dictionary<string, LeagueChallengeName>
    {
        /// <summary>
        /// Gets a League of Legends challenge localized name and descriptions with specified Riot Locale ID or languagecode2-country code
        /// </summary>
        /// <param name="localeId">Riot Formatted locale ID of languagecode2-country code</param>
        /// <returns><see cref="LeagueChallengeName"/> with specified locale ID or <see langword="null"/> if nothing found for specified locale ID</returns>
        public new LeagueChallengeName this[string localeId]
        {
            get
            {
                if (localeId.Contains('-'))
                    localeId = localeId.Replace('-', '_');

                return this.FirstOrDefault(c => c.Key == localeId).Value;
            }

            private set
            {
                this.Add(localeId.Replace('-', '_'), value);
            }
        }

        /// <summary>
        /// Gets a League of Legends localized name and descriptions by specified <see cref="CultureInfo"/> data
        /// </summary>
        /// <param name="cultureInfo"><see cref="CultureInfo"/> to search for</param>
        /// <returns><see cref="LeagueChallengeName"/> with specified locale ID or <see langword="null"/> if nothing found for specified <see cref="CultureInfo"/></returns>
        public LeagueChallengeName this[CultureInfo cultureInfo]
        {
            get
            {
                return this.FirstOrDefault(c => c.Key.Replace('_', '-') == cultureInfo.Name).Value;
            }
        }
    }
}
