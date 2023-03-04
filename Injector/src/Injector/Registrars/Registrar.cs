using Injector.Config;
using Injector.Contracts.Services;
using Injector.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace Injector.Registrars
{
    internal class Registrar : IRegistrar
    {
        private readonly IServiceCollection _services;
        private readonly InjectorConfig _config;

        internal Registrar(IServiceCollection services, InjectorConfig config)
        {
            _services = services;
            _config = config;
        }

        void IRegistrar.Register(IEnumerable<Type> injectables)
        {
            if (_config.RegisterServices)
                RegisterServices(injectables);

            if (_config.RegisterHostedServices)
                RegisterHostedServices(injectables);
        }

        private void RegisterServices(IEnumerable<Type> injectables)
        {
            var singletonServices = TypeUtilities.FilterClassesByImplementedInterface(injectables, typeof(ISingleton));
            if (singletonServices != null && singletonServices.Any())
                RegisterGenericServices(singletonServices, typeof(ISingleton<>), ServiceLifetime.Singleton);
            var transientServices = TypeUtilities.FilterClassesByImplementedInterface(injectables, typeof(ITransient));
            if (transientServices != null && transientServices.Any())
                RegisterGenericServices(transientServices, typeof(ITransient<>), ServiceLifetime.Transient);
            var scopedService = TypeUtilities.FilterClassesByImplementedInterface(injectables, typeof(IScoped));
            if (scopedService != null && scopedService.Any())
                RegisterGenericServices(scopedService, typeof(IScoped<>), ServiceLifetime.Scoped);
        }

        private void RegisterHostedServices(IEnumerable<Type> injectables)
        {
            var hostedService = TypeUtilities.FilterClassesByImplementedInterface(injectables, typeof(IHostedService));
            if (hostedService != null && hostedService.Any())
                RegisterGenericHostedService(hostedService);
        }

        private void RegisterGenericHostedService(IEnumerable<Type> types)
        {
            foreach (var type in types)
            {
                Register(new ServiceDescriptor(type, typeof(IHostedService), ServiceLifetime.Singleton));
            }
        }

        private void RegisterGenericServices(IEnumerable<Type> types, Type genericInterfaceType, ServiceLifetime serviceLifetime)
        {
            foreach (var type in types)
            {
                var genericType = TypeUtilities.GetGenericInterfaceGenericType(type, genericInterfaceType);
                if (genericType == null)
                    Register(new ServiceDescriptor(type, type, serviceLifetime));
                else
                    Register(new ServiceDescriptor(genericType, type, serviceLifetime));
            }
        }

        private void Register(ServiceDescriptor serviceDescriptor)
        {
            if (_config.RegistrationStrategy.Equals(RegistrationStrategy.ThrowException))
            {
                _services.Add(serviceDescriptor);
            }
            else if (_config.RegistrationStrategy.Equals(RegistrationStrategy.IgnoreIssues))
            {
                _services.TryAdd(serviceDescriptor);
            }
            else
            {
                throw new NotImplementedException("Unknown RegistrationStrategy!");
            }
        }
    }
}
