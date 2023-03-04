namespace Injector.Contracts.Services
{
    /// <summary>
    /// Classes that Implements this interface are registered as Singleton service
    /// Registeration is handled by Injector package
    /// </summary>
    public interface ISingleton : Injectable
    {
    }

    /// <summary>
    /// <inheritdoc cref="ISingleton"/>
    /// </summary>
    /// <typeparam name="TBase">Interface which the class implements to be used for service registeration</typeparam>
    public interface ISingleton<TBase> : ISingleton
    {
    }
}
