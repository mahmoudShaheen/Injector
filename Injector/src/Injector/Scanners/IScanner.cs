using System.Reflection;

namespace Injector.Scanners
{
    internal interface IScanner
    {
        internal IEnumerable<Type> Scan(Assembly assembly);
    }
}
