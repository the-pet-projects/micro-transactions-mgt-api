namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.CQRS.Commands
{
    using System.Threading.Tasks;
    using Results;

    public interface ICommandHandlerAsync<in TCommand>
        where TCommand : ICommand
    {
        Task<IResult> HandleAsync(TCommand command);
    }
}