namespace Injector.Contracts.Services
{
    public interface IScoped : Injectable
    {
    }

    public interface IScoped<TBase> : IScoped
    {
    }
}
