using EntityFramework.Triggers;
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
}
