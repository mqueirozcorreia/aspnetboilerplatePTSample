using Abp.EntityFramework;
using AplicacoesWeb.People;
using AplicacoesWeb.Tasks;
using System.Data.Entity;

namespace AplicacoesWeb.EntityFramework
{
    public class AplicacoesWebDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AplicacoesWebDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AplicacoesWebDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AplicacoesWebDbContext since ABP automatically handles it.
         */
        public AplicacoesWebDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public virtual IDbSet<Task> Tasks { get; set; }

        public virtual IDbSet<Person> People { get; set; }
    }
}
