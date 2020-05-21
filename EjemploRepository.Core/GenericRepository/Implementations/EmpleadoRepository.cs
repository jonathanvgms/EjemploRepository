using System;

namespace EjemploRepository.Core.GenericRepository.Implementations
{
    public class EjemploRepository : GenericRepository<DbContext, Empleado>
    {
        public EjemploRepository(DbContext context) : base(context)
        {
        }
    }
}