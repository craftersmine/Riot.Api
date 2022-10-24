using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    /// <summary>
    /// Occurs when API tournament endpoint requested that is not available in Stub API
    /// </summary>
    [Serializable]
    public class TournamentStubUsedException : Exception
    {
        /// <inheritdoc cref="TournamentStubUsedException(string,Exception)"/>
        public TournamentStubUsedException()
        {
        }

        /// <inheritdoc cref="TournamentStubUsedException(string,Exception)"/>
        public TournamentStubUsedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="TournamentStubUsedException"/>
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner exception that caused it</param>
        public TournamentStubUsedException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected TournamentStubUsedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
