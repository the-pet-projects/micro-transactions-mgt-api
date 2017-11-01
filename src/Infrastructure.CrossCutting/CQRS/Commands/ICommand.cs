namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.CQRS.Commands
{
    using Results;

    public interface ICommand
    {
        IResult Validate();
    }
}