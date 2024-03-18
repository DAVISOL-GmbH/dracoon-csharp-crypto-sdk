using System;
using System.Runtime.Serialization;

namespace Dracoon.Crypto.Sdk {
    /// <summary>
    /// Signals a problem with the file key.
    /// </summary>
    [Serializable]
    public class InvalidFileKeyException : CryptoException {

        /// <inheritdoc/>
        public InvalidFileKeyException() { }

        /// <inheritdoc/>
        public InvalidFileKeyException(string message) : base(message) { }

        /// <inheritdoc/>
        public InvalidFileKeyException(string message, Exception cause) : base(message, cause) { }

        /// <inheritdoc/>
#if NET8_0_OR_GREATER
        // Serialization ctor is obsolete starting with .NET 8.0
        [Obsolete("Legacy serialization infrastructure APIs marked obsolete (https://github.com/dotnet/docs/issues/34893)", DiagnosticId = "SYSLIB0051")]
#endif
        protected InvalidFileKeyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
