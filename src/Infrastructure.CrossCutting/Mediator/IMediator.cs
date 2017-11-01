namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.Mediator
{
    using System.Threading.Tasks;
    using CQRS.Commands;
    using CQRS.Queries;
    using Results;

    public interface IMediator
    {
        TResponse Query<TQuery, TResponse>(TQuery query) where TQuery : IQuery<TResponse>;

        void RunCommand<TCommand>(TCommand command) where TCommand : ICommand;

        Task<TResponse> QueryAsync<TQuery, TResponse>(TQuery query) where TQuery : IQuery<Task<TResponse>>;

        Task RunCommandAsync<TCommand>(TCommand command) where TCommand : ICommand;

        Task<IResult> RunCommandWithFeedbackAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}