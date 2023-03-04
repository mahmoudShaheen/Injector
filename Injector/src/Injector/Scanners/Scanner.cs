using Injector.Config;
using Injector.Contracts;
using System.Reflection;

namespace Injector.Scanners
{
    internal class Scanner : IScanner
    {
        internal Scanner(InjectorConfig config)
        {
        }

        IEnumerable<Type> IScanner.Scan(Assembly assembly)
        {
            var type = typeof(Injectable);
            return assembly.GetTypes()
                .Where(t => type.IsAssignableFrom(t));
        }
    }
}
