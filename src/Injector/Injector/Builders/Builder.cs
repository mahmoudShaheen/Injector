using Injector.Config;
using Injector.Registrars;
using Injector.Scanners;
using System.Reflection;

namespace Injector.Builders
{
    internal class Builder : IBuilder
    {
        private readonly IScanner _scanner;
        private readonly IRegistrar _registrar;
        private readonly HashSet<Assembly> _scannedAssemblies;

        public Builder(IScanner scanner, IRegistrar registerar, InjectorConfig config)
        {
            _scanner = scanner;
            _registrar = registerar;
            _scannedAssemblies = new HashSet<Assembly>();
        }

        public IBuilder RegisterModule(Type assemblyMarkerType)
        {
            var assembly = assemblyMarkerType.Assembly;
            if (_scannedAssemblies.Contains(assembly))
                return this;

            // Scan Assembly for Types that implements Injectable
            _scannedAssemblies.Add(assemblyMarkerType.Assembly);
            var injectables = _scanner.Scan(assembly);
            
            // Register Found Types
            if(injectables != null && injectables.Any())
                _registrar.Register(injectables);

            return this;
        }

        public IBuilder RegisterModules(params Type[] assemblyMarkerTypes)
        {
            foreach (var assemblyMarkerType in assemblyMarkerTypes.Distinct())
            {
                RegisterModule(assemblyMarkerType);
            }
            return this;
        }
    }
}
