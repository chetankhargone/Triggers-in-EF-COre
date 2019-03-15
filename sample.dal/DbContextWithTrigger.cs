using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace sample.dal
{
    public class DbContextWithTrigger : DbContext
    {
        public Boolean TriggersEnabled { get; set; } = true;
    }
}
