using ParkingApplication.Interfaces;
using ParkingDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApplication.Commands
{
    public class OperationCommand : ICommand<Operation>
    {
        private readonly IServices<Operation> _services;
        public OperationCommand()
        {
            _services = new OperationRes();
        }
        public Task Delete(Operation obj)
        {
           return _services.Delete(obj.Id);
        }

        public Task<List<Operation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Operation> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Save(Operation obj)
        {
            throw new NotImplementedException();
        }

        public Task Update(Operation obj)
        {
            throw new NotImplementedException();
        }
    }
}
