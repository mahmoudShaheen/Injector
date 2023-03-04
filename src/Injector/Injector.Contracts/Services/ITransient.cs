namespace Injector.Contracts.Services
{
    /// <summary>
    /// Classes that Implements this interface are registered as Transient service
    /// Registeration is handled by Injector package
    /// </summary>
    public interface ITransient : Injectable
    {
    }

    /// <summary>
    /// <inheritdoc cref="ITransient"/>
    /// </summary>
    /// <typeparam name="TBase">Interface which the class implements to be used for service registeration</typeparam>
    public interface ITransient<TBase> : ITransient
    {
    }
}
