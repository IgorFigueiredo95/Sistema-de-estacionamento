using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApplication.Interfaces
{
    public interface IServices<Tentity> : IDisposable
    {
        public Task Create(Tentity obj);

        public Task Delete(Guid id);

        public void Dispose();

        public Task<List<Tentity>> Select();



        public Task<Tentity> Select(Guid id);

        public Task Update(Tentity obj);
    }
}
