using System;
using System.Runtime.Serialization;

namespace Dracoon.Crypto.Sdk {
    /// <summary>
    /// Signals a crypto problem.
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="InvalidPasswordException"/></description>
    /// <description><see cref="InvalidKeyPairException"/></description>
    /// <description><see cref="InvalidFileKeyException"/></description>
    /// <description><see cref="BadFileException"/></description>
    /// <description><see cref="CryptoSystemException"/></description>
    /// </item>
    /// </list>
    /// </summary>
    [Serializable]
    public class CryptoException : Exception {

        /// <inheritdoc/>
        public CryptoException() { }

        /// <inheritdoc/>
        public CryptoException(string message) : base(message) { }

        /// <inheritdoc/>
        public CryptoException(string message, Exception cause) : base(message, cause) { }

        /// <inheritdoc/>
#if NET8_0_OR_GREATER
        // Serialization ctor is obsolete starting with .NET 8.0
        [Obsolete("Legacy serialization infrastructure APIs marked obsolete (https://github.com/dotnet/docs/issues/34893)", DiagnosticId = "SYSLIB0051")]
#endif
        protected CryptoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
