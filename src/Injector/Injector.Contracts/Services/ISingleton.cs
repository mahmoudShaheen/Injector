namespace Injector.Contracts.Services
{
    public interface ISingleton : Injectable
    {
    }

    public interface ISingleton<TBase> : ISingleton
    {
    }
}
