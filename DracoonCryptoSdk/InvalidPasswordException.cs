using System;
using System.Runtime.Serialization;

namespace Dracoon.Crypto.Sdk {
    /// <summary>
    /// Signals a problem with the password.
    /// </summary>
    [Serializable]
    public class InvalidPasswordException : CryptoException {

        /// <inheritdoc/>
        public InvalidPasswordException() { }

        /// <inheritdoc/>
        public InvalidPasswordException(string message) : base(message) { }

        /// <inheritdoc/>
        public InvalidPasswordException(string message, Exception cause) : base(message, cause) { }

        /// <inheritdoc/>
#if NET8_0_OR_GREATER
        // Serialization ctor is obsolete starting with .NET 8.0
        [Obsolete("Legacy serialization infrastructure APIs marked obsolete (https://github.com/dotnet/docs/issues/34893)", DiagnosticId = "SYSLIB0051")]
#endif
        protected InvalidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
