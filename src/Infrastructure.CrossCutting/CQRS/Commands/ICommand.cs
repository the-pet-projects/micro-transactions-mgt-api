namespace Infrastructure.CrossCutting.CQRS.Commands
{
    using Results;

    public interface ICommand
    {
        IResult Validate();
    }
}