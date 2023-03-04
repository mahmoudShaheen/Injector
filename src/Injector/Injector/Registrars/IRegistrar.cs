namespace Injector.Registrars
{
    internal interface IRegistrar
    {
        internal void Register(IEnumerable<Type> injectables);
    }
}