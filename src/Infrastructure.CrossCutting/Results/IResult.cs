namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.Results
{
    using System.Collections.Generic;

    public interface IResult
    {
        bool Sucess { get; }

        ICollection<Error> AggregateErrors { get; }
    }
}