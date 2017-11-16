namespace PetProjects.MtsManagementApi.Domain.Model
{
    using System;
    using System.Collections.Generic;

    public abstract class AggregateRoot
    {
        private readonly List<Event> changes = new List<Event>();

        public abstract Guid Id { get; }

        public int Version { get; internal set; }

        public IEnumerable<Event> GetUncommitedChanges()
        {
            return this.changes;
        }

        public void MarkChangesAsCommited()
        {
            this.changes.Clear();
        }

        public void LoadFromHistory(IEnumerable<Event> history)
        {
            foreach (var @event in history)
            {
                this.ApplyChange(@event, false);
            }
        }

        protected void ApplyChange(Event @event)
        {
            this.ApplyChange(@event, true);
        }

        protected abstract void Apply(Event @event);

        private void ApplyChange(Event @event, bool isNew)
        {
            this.Apply(@event);

            if (isNew)
            {
                this.changes.Add(@event);
            }
        }
    }
}