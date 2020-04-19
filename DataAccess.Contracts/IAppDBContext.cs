using DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IAppDBContext
    {

       // DbSet<UserEntity> Users { get; set; }
        DbSet<Persona> Personas { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        void RemoveRange(IEnumerable<object> entities);

        EntityEntry Update(object entity);

    }
}
