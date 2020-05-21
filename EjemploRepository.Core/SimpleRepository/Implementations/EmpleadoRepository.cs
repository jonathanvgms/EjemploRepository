using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EjemploRepository.Core.SimpleRepository.Interfaces;

namespace EjemploRepository.Core.SimpleRepository.Implementations
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        public Task<Empleado> Add(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Edit(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empleado>> Find(Expression<Func<Empleado, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empleado>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Remove(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}