using ParkingApplication.Interfaces;
using ParkingDomain.Entities;
using ParkingInfrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingInfrastructure.Repository
{
   public class OperationRes : IServices<Operation>
    {
        public Task Create(Operation obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Operation>> Select()
        {
            throw new NotImplementedException();
        }

        public Task<Operation> Select(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Operation obj)
        {
            throw new NotImplementedException();
        }
    }
}
