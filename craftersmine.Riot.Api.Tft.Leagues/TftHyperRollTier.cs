using System;
using System.Collections.Generic;
using System.Text;

namespace craftersmine.Riot.Api.Tft.Leagues
{
    /// <summary>
    /// Represents a Teamfight Tactics Hyper Roll ranked tier
    /// </summary>
    public enum TftHyperRollTier
    {
        /// <summary>
        /// Unknown or unranked
        /// </summary>
        Unknown,
        /// <summary>
        /// Gray Hyper Roll rank tier
        /// </summary>
        Gray,
        /// <summary>
        /// Green Hyper Roll rank tier
        /// </summary>
        Green,
        /// <summary>
        /// Blue Hyper Roll rank tier
        /// </summary>
        Blue,
        /// <summary>
        /// Purple Hyper Roll rank tier
        /// </summary>
        Purple,
        /// <summary>
        /// Hyper Hyper Roll rank tier
        /// </summary>
        Hyper
    }

    /// <summary>
    /// Contains static extension methods for <see cref="TftHyperRollTier"/>
    /// </summary>
    public static class TftHyperRollTierExtensions
    {
        private const string Gray = "GRAY";
        private const string Green = "GREEN";
        private const string Blue = "BLUE";
        private const string Purple = "PURPLE";
        private const string Hyper = "ORANGE";

        /// <summary>
        /// Gets a corresponding string for <see cref="TftHyperRollTier"/> value
        /// </summary>
        /// <param name="hyperRollTier">TFT Hyper Roll tier</param>
        /// <returns>A corresponding <see langword="string"/> for <see cref="TftHyperRollTier"/> value</returns>
        /// <exception cref="ArgumentException">When an unknown value selected</exception>
        public static string GetStringFor(this TftHyperRollTier hyperRollTier)
        {
            switch (hyperRollTier)
            {
                case TftHyperRollTier.Gray:
                    return Gray;
                case TftHyperRollTier.Green:
                    return Green;
                case TftHyperRollTier.Blue:
                    return Blue;
                case TftHyperRollTier.Purple:
                    return Purple;
                case TftHyperRollTier.Hyper:
                    return Hyper;
                default:
                    throw new ArgumentException("Unknown TFT Hyper Roll tier selected", nameof(hyperRollTier));
            }
        }

        internal static TftHyperRollTier GetTftHyperRollTierFromString(this string str)
        {
            switch (str)
            {
                case Gray:
                    return TftHyperRollTier.Gray;
                case Green:
                    return TftHyperRollTier.Green;
                case Blue:
                    return TftHyperRollTier.Blue;
                case Purple:
                    return TftHyperRollTier.Purple;
                case Hyper:
                    return TftHyperRollTier.Hyper;
                default:
                    return TftHyperRollTier.Unknown;
            }
        }
    }
}
