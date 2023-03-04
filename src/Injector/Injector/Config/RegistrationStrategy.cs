using Microsoft.Extensions.DependencyInjection;

namespace Injector.Config
{
    /// <summary>
    /// Strategy used to handle Registeration Errors,
    /// Default: <see cref="IgnoreIssues"/>
    /// </summary>
    public enum RegistrationStrategy
    {
        /// <summary>
        /// [Default] Ignore Confilicts: Uses <see cref="IServiceCollection.TryAdd(ServiceDescriptor)"/>
        /// </summary>
        IgnoreIssues,

        /// <summary>
        /// Throw exception when Conflict occurs: Uses <see cref="IServiceCollection.Add(ServiceDescriptor)"/>
        /// </summary>
        ThrowException,
    }
}
