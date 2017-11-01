using App.Data.Entity;
using App.Data.Infrastructure;
using static App.Data.Repository.EmployeeRepository;

namespace App.Data.Repository
{
  public class EmployeeRepository: RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
       public interface IEmployeeRepository : IRepository<Employee>
        {

        }
    }
}
