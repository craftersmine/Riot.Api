using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace craftersmine.Riot.Api.Valorant.Content
{
    /// <summary>
    /// Represents a collection of localized names for Valorant Content Item
    /// </summary>
    public class ValorantLocalizedNamesCollection : Dictionary<string, string>
    {
        /// <summary>
        /// Gets a localized string for item for specified locale
        /// </summary>
        /// <param name="locale">String locale code with format of xx-XX (ex. en-US, ru-RU, etc.)</param>
        /// <returns>A localized <see cref="string"/> for specified locale</returns>
        public new string this[string locale] => base[locale];

        /// <summary>
        /// Gets a localized string for item for specified locale
        /// </summary>
        /// <param name="locale"><see cref="CultureInfo"/> with specified locale information</param>
        /// <returns>A localized <see cref="string"/> for specified locale</returns>
        public string this[CultureInfo locale] => base[locale.Name];

        /// <summary>
        /// Checks if specified locale is exists in collection and returns <see langword="true"/> if it exists, otherwise <see langword="false"/>
        /// </summary>
        /// <param name="locale">String locale code with format of xx-XX (ex. en-US, ru-RU, etc.)</param>
        /// <returns><see langword="true"/> if exists, otherwise <see langword="false"/></returns>
        public bool IsLocaleExists(string locale)
        {
            return ContainsKey(locale);
        }
        
        /// <summary>
        /// Checks if specified locale is exists in collection and returns <see langword="true"/> if it exists, otherwise <see langword="false"/>
        /// </summary>
        /// <param name="locale"><see cref="CultureInfo"/> with specified locale information</param>
        /// <returns><see langword="true"/> if exists, otherwise <see langword="false"/></returns>
        public bool IsLocaleExists(CultureInfo locale)
        {
            return IsLocaleExists(locale.Name);
        }
    }
}
