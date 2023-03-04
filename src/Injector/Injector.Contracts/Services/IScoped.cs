namespace Injector.Contracts.Services
{
    /// <summary>
    /// Classes that Implements this interface are registered as Scoped service
    /// Registeration is handled by Injector package
    /// </summary>
    public interface IScoped : Injectable
    {
    }

    /// <summary>
    /// <inheritdoc cref="IScoped"/>
    /// </summary>
    /// <typeparam name="TBase">Interface which the class implements to be used for service registeration</typeparam>
    public interface IScoped<TBase> : IScoped
    {
    }
}
