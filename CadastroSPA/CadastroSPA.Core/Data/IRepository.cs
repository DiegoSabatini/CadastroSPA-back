using CadastroSPA.Core.DomainObjects;


namespace CadastroSPA.Core.Data
{
    public interface IRepository<T> : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
