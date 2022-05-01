using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApplication.Interfaces
{
    public interface ICommand<Tentity>
    {
        public Task<List<Tentity>> GetAll();
        public Task<Tentity> GetById(Guid id);
        public Task Save(Tentity obj);
        public Task Update(Tentity obj);
        public Task Delete(Tentity obj);
    }
}
