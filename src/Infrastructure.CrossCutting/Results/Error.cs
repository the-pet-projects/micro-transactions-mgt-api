namespace PetProjects.MtsManagementApi.Infrastructure.CrossCutting.Results
{
    using System;

    public class Error
    {
        public string Message { get; set; }

        public Exception Exception { get; set; }
    }
}