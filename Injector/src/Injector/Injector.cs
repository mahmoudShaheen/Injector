using Injector.Builders;
using Injector.Config;
using Injector.Registrars;
using Injector.Scanners;
using Microsoft.Extensions.DependencyInjection;

namespace Injector
{
    public static class Injector
    {
        /// <summary>
        /// Intialize Injector and returns <see cref="IBuilder"/> 
        /// to be used for Registering App Modules.
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <param name="configAction"><see cref="InjectorConfig"/></param>
        /// <returns><see cref="IBuilder"/></returns>
        public static IBuilder AddInjector(this IServiceCollection services, Action<InjectorConfig>? configAction = null)
        {
            var config = new InjectorConfig();
            configAction?.Invoke(config);

            var scanner = new Scanner(config);
            var registrar = new Registrar(services, config);
            return new Builder(scanner, registrar, config);
        }
    }
}
