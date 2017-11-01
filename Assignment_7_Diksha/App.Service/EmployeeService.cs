using App.Data.Entity;
using App.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static App.Data.Repository.EmployeeRepository;
using static App.Service.EmployeeService;

namespace App.Service
{
   public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository empRepository;
        private readonly IUnitOfWork unitOfWork;
        public EmployeeService(IEmployeeRepository EmpRepository, IUnitOfWork unitOfWork)
        {
            this.empRepository = EmpRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return empRepository.GetEmployees();
        }
        public interface IEmployeeService
        {
            IEnumerable<Employee> GetAllEmployees();
        }
    }
}
