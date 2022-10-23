using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace craftersmine.Riot.Api.Status
{
    /// <summary>
    /// Represents a collection of Riot Service Status contents
    /// </summary>
    public class RiotServiceStatusContentCollection : List<RiotServiceStatusContent>
    {
        /// <summary>
        /// Gets a status content by specified culture info
        /// </summary>
        /// <param name="cultureInfo">Culture info for which get status content</param>
        /// <returns><see cref="RiotServiceStatusContent"/> with specified localization or <see langword="null"/> if status content not found</returns>
        public RiotServiceStatusContent GetContentForLocale(CultureInfo cultureInfo)
        {
            return this.FirstOrDefault(c => c.Locale.Name == cultureInfo.Name);
        }
        
        /// <summary>
        /// Gets a status content by specified Riot locale code
        /// </summary>
        /// <param name="localeCode">Riot Games locale code for which get status content</param>
        /// <returns><see cref="RiotServiceStatusContent"/> with specified localization or <see langword="null"/> if status content not found</returns>
        public RiotServiceStatusContent GetContentForLocale(string localeCode)
        {
            if (localeCode.Contains("_"))
                localeCode = localeCode.Replace("_", "-");
            return GetContentForLocale(new CultureInfo(localeCode));
        }
    }
}
