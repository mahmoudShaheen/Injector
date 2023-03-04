namespace Injector.Utilities
{
    internal static class TypeUtilities
    {
        internal static IEnumerable<Type>? FilterClassesByImplementedInterface(IEnumerable<Type> classes, Type interfaceType)
        {
            return classes.Where(t => t.GetInterfaces().Any(i => i.Equals(interfaceType)));
        }

        internal static Type? GetGenericInterfaceGenericType(Type classType, Type interfaceType)
        {
            return classType
                .GetInterfaces()?
                .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == interfaceType)?
                .SelectMany(i => i.GetGenericArguments())?
                .FirstOrDefault();
        }
    }
}
