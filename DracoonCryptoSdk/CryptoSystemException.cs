using System;
using System.Runtime.Serialization;

namespace Dracoon.Crypto.Sdk {
    /// <summary>
    /// Signals that an unexpected crypto error occurred. (Mostly missing algorithms, unsupported padding, ...)
    /// </summary>
    [Serializable]
    public class CryptoSystemException : CryptoException {

        /// <inheritdoc/>
        public CryptoSystemException() { }

        /// <inheritdoc/>
        public CryptoSystemException(string message) : base(message) { }

        /// <inheritdoc/>
        public CryptoSystemException(string message, Exception cause) : base(message, cause) { }

        /// <inheritdoc/>
#if NET8_0_OR_GREATER
        // Serialization ctor is obsolete starting with .NET 8.0
        [Obsolete("Legacy serialization infrastructure APIs marked obsolete (https://github.com/dotnet/docs/issues/34893)", DiagnosticId = "SYSLIB0051")]
#endif
        protected CryptoSystemException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
