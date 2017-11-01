namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.CQRS.Queries
{
    using System.Threading.Tasks;

    public interface IQueryHandlerAsync<in TQuery, TResponse>
        where TQuery : IQuery<Task<TResponse>>
    {
        Task<TResponse> HandleAsync(TQuery query);
    }
}