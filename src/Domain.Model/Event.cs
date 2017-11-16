namespace PetProjects.MtsManagementApi.Domain.Model
{
    using System;

    public class Event : IMessage
    {
        public long Version => this.GetUnixTimestamp();

        public long GetUnixTimestamp()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}