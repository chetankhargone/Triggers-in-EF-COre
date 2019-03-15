using EntityFrameworkCore.Triggers;
using sample.dal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sample.dal.Db
{
    public class CustomerHandler
    {
        private readonly SampleAppContext _dbContext;
        public CustomerHandler()
        {
            _dbContext = new SampleAppContext();
        }

        public async Task<bool> Save(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesWithTriggersAsync(_dbContext.SaveChangesAsync);
            return true;
        }
    }
}
