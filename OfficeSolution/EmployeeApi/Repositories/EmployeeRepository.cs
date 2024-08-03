using EmployeeApi.Models;

namespace EmployeeApi.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly OfficeDbContext _context;
		public EmployeeRepository(OfficeDbContext context)
		{
			_context = context;
		}

		public Employee AddEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public Employee GetEmployee(int employeeId)
		{
			return _context.Employees.FirstOrDefault(e => e.Id == employeeId)!;
		}

		public IEnumerable<Employee> GetEmployees()
		{
			return _context.Employees.ToList();
		}

		public Employee UpdateEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}
	}

	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetEmployees();

		Employee GetEmployee(int employeeId);

		Employee AddEmployee(Employee employee);

		Employee UpdateEmployee(Employee employee);
	}
}