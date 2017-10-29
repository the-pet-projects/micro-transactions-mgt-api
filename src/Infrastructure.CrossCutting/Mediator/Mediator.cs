namespace Infrastructure.CrossCutting.Mediator
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CQRS.Commands;
    using CQRS.Queries;
    using Results;

    public class Mediator : IMediator
    {
        private readonly Dictionary<Type, Creator> typeMapper = new Dictionary<Type, Creator>();

        public delegate object Creator(Mediator container);

        public void Register<T>(Creator creator)
        {
            this.typeMapper.Add(typeof(T), creator);
        }

        public TResponse Query<TQuery, TResponse>(TQuery query)
            where TQuery : IQuery<TResponse>
        {
            var handler = this.Create<IQueryHandler<TQuery, TResponse>>();

            return handler.Handle(query);
        }

        public void RunCommand<TCommand>(TCommand command)
            where TCommand : ICommand
        {
            var handler = this.Create<ICommandHandler<TCommand>>();

            handler.Handle(command);
        }

        public async Task<TResponse> QueryAsync<TQuery, TResponse>(TQuery query)
            where TQuery : IQuery<Task<TResponse>>
        {
            var handler = this.Create<IQueryHandlerAsync<IQuery<Task<TResponse>>, TResponse>>();

            return await handler.HandleAsync(query);
        }

        public async Task RunCommandAsync<TCommand>(TCommand command)
            where TCommand : ICommand
        {
            var handler = this.Create<ICommandHandlerAsync<TCommand>>();

            await handler.HandleAsync(command);
        }

        public async Task<IResult> RunCommandWithFeedbackAsync<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = this.Create<ICommandHandlerAsync<TCommand>>();

            return await handler.HandleAsync(command);
        }

        private T Create<T>()
        {
            if (this.typeMapper.ContainsKey(typeof(T)))
            {
                return (T)this.typeMapper[typeof(T)](this);
            }

            return default(T);
        }
    }
}