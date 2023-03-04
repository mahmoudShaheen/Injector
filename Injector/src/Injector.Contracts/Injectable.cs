using Injector.Contracts.Services;

namespace Injector.Contracts
{
    //Marker
    /// <summary>
    /// Marker Interface implemented by all other interfaces
    /// used by Injector to find all classes that implements any interface from Injector.Contracts
    /// Don't use it in any of your classes instead use one of the following"
    /// <see cref="ISingleton"/>, <see cref="IScoped"/>, <see cref="ITransient"/>,
    /// <see cref="ISingleton{TBase}"/>, <see cref="IScoped{TBase}"/>, <see cref="ITransient{TBase}"/>.
    /// </summary>
    public interface Injectable
    {
    }
}
