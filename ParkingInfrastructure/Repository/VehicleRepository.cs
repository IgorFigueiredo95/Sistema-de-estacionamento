using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParkingDomain.Entities;
using ParkingApplication.Interfaces;
using ParkingInfrastructure.Context;

namespace ParkingInfrastructure.Repository
{
    public class VehicleRepository : IServices<Vehicle>
    {
        private ParkingDBContext _context;

        public VehicleRepository(ParkingDBContext context)
        {
            _context = context;
        }

        public async Task Create(Vehicle obj)
        {
            _context.Vehicles.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var result = await _context.Vehicles.FirstOrDefaultAsync(x => x.Id == id);
            _context.Vehicles.Remove(result);
            _context.SaveChangesAsync();
          
        }

        public  async Task<List<Vehicle>> Select()
        {
           return await  _context.Vehicles.AsNoTracking().ToListAsync();
        }

        public async Task<Vehicle> Select(Guid id)
        {
            return await _context.Vehicles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Vehicle obj)
        {
            _context.Entry(obj).State = EntityState.Modified;///Informa ao tracking feito pelo EF que o objeto "obj" teve o seu estado alterado.
            _context.SaveChangesAsync();// Salva todas as alterações "trackeadas" pelo EF
     
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
