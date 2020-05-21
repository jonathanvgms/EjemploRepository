using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EjemploRepository.Core.SimpleRepository.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<Empleado> GetById(int id);

        Task<IEnumerable<Empleado>> GetAll();

        Task<IEnumerable<Empleado>> Find(Expression<Func<Empleado, bool>> predicado);

        Task<Empleado> Add(Empleado empleado);

        Task<Empleado> Remove(Empleado empleado);

        Task<Empleado> Edit(Empleado empleado);

        void Save();
    }
}