using Injector.Builders;
using Injector.Config;
using Injector.Registrars;
using Injector.Scanners;
using Microsoft.Extensions.DependencyInjection;

namespace Injector
{
    public static class Injector
    {
        public static IBuilder AddInjector(this IServiceCollection services, InjectorConfig? config = null)
        {
            config ??= new InjectorConfig();

            var scanner = new Scanner(config);
            var registrar = new Registrar(services, config);
            return new Builder(scanner, registrar, config);
        }
    }
}
