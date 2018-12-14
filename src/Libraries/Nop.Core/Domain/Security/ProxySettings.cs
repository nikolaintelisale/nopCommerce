using Nop.Core.Configuration;

namespace Nop.Core.Domain.Security
{
    /// <summary>
    /// Proxy settings
    /// </summary>
    public class ProxySettings : ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether we should use proxy connection
        /// </summary>
        public bool ProxyEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether to bypass the proxy server for local addresses
        /// </summary>
        public bool ProxyBypassProxyOnLocal { get; set; }

        /// <summary>
        /// Gets or sets the address of the proxy server
        /// </summary>
        public string ProxyAddress { get; set; }

        /// <summary>
        /// Gets or sets the port of the proxy server
        /// </summary>
        public string ProxyPort { get; set; }

        /// <summary>
        /// Gets or sets the user name for proxy connection
        /// </summary>
        public string ProxyUserName { get; set; }

        /// <summary>
        /// /// Gets or sets the password for proxy connection
        /// </summary>
        public string ProxyPassword { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the handler sends an Authorization header with the request
        /// </summary>
        public bool ProxyPreAuthenticate { get; set; }
    }
}