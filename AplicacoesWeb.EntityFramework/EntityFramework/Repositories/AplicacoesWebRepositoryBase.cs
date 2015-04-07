using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AplicacoesWeb.EntityFramework.Repositories
{
    public abstract class AplicacoesWebRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AplicacoesWebDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AplicacoesWebRepositoryBase(IDbContextProvider<AplicacoesWebDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AplicacoesWebRepositoryBase<TEntity> : AplicacoesWebRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AplicacoesWebRepositoryBase(IDbContextProvider<AplicacoesWebDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
