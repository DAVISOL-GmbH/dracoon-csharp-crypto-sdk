using System;
using System.Runtime.Serialization;

namespace Dracoon.Crypto.Sdk {
    /// <summary>
    /// Signals a problem with the user's key pair.
    /// </summary>
    [Serializable]
    public class InvalidKeyPairException : CryptoException {

        /// <inheritdoc/>
        public InvalidKeyPairException() { }

        /// <inheritdoc/>
        public InvalidKeyPairException(string message) : base(message) { }

        /// <inheritdoc/>
        public InvalidKeyPairException(string message, Exception cause) : base(message, cause) { }

        /// <inheritdoc/>
#if NET8_0_OR_GREATER
        // Serialization ctor is obsolete starting with .NET 8.0
        [Obsolete("Legacy serialization infrastructure APIs marked obsolete (https://github.com/dotnet/docs/issues/34893)", DiagnosticId = "SYSLIB0051")]
#endif
        protected InvalidKeyPairException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
