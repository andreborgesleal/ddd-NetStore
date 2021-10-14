using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = new Guid();
        }
        public override bool Equals(object obj)
        {
            var comparedTo = obj as Entity;

            if (ReferenceEquals(this, comparedTo)) return true;
            if (ReferenceEquals(null, comparedTo)) return false;

            return Id.Equals(comparedTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return true;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode() => (GetType().GetHashCode() * 907) + Id.GetHashCode();

        public override string ToString() => $"{GetType().Name} [Id={Id}]";

    }
}
