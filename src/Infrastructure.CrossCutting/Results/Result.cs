namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.Results
{
    using System.Collections.Generic;

    public class Result : IResult
    {
        public Result()
        {
            this.Sucess = true;
            this.AggregateErrors = new List<Error>();
        }

        public bool Sucess { get; private set; }

        public ICollection<Error> AggregateErrors { get; }

        public void Add(Error error)
        {
            this.AggregateErrors.Add(error);
        }

        public void Fail()
        {
            this.Sucess = false;
        }

        public void Success()
        {
            this.Sucess = true;
        }
    }
}