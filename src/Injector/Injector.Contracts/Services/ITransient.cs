namespace Injector.Contracts.Services
{
    public interface ITransient : Injectable
    {
    }

    public interface ITransient<TBase> : ITransient
    {
    }
}
