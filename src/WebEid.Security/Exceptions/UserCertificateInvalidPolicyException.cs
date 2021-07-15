namespace WebEid.Security.Exceptions
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    /// <summary>
    ///  Thrown when the user certificate policy is invalid.
    /// </summary>
    [Serializable]
    public class UserCertificateInvalidPolicyException : TokenValidationException
    {
        public UserCertificateInvalidPolicyException() : base("User certificate policy is invalid")
        {
        }

        [ExcludeFromCodeCoverage]
        protected UserCertificateInvalidPolicyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
