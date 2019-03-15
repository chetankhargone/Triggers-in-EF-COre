using EntityFrameworkCore.Triggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace sample.dal.Models
{
    public abstract class Trackable
    {
        public DateTime Inserted { get; private set; }
        public DateTime Updated { get; private set; }

        static Trackable()
        {
            Triggers<Trackable>.Inserted += entry => entry.Entity.Inserted = entry.Entity.Updated = DateTime.UtcNow;
            Triggers<Trackable>.Updated += entry => entry.Entity.Updated = DateTime.UtcNow;
        }
    }

    public abstract class SoftDeletable : Trackable
    {
        public virtual DateTime? Deleted { get; private set; }
        public Boolean IsSoftDeleted => Deleted != null;
        public void SoftDelete() => Deleted = DateTime.UtcNow;

        static SoftDeletable()
        {
            Triggers<SoftDeletable>.Deleting += entry =>
            {
                entry.Entity.SoftDelete();
            };
        }
    }

}
