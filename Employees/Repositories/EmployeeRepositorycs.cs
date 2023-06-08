using Employees.Context;
using Employees.Models;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Repositories
{
    public static class EmployeeRepositorycs
    {
        private static readonly EmployeeContext _employeeContext = new EmployeeContext();

        public static void AddEmployee(string name, int age, Car car)
        {
            _employeeContext.Employees.Add(new Employee() { Name = name, Age = age, Car = car });
            _employeeContext.SaveChanges();
        }
        public static void RemoveByName(string name)
        {
            _employeeContext.Employees.RemoveRange(_employeeContext.Employees.Where(x => x.Name == name));
            _employeeContext.SaveChanges();
        }
        public static void RemoveByCar(Car car)
        {
            _employeeContext.Employees.Remove(_employeeContext.Employees.FirstOrDefault(x => x.Car == car));
        }
        public static IEnumerable<Employee> FindAllByName(string name)
        {
            return _employeeContext.Employees.Where(x => x.Name == name);
        }
        public static IEnumerable<Employee> FindAllByCar(Car car)
        {
            return _employeeContext.Employees.Where(x => x.Car == car);
        }
        public static IEnumerable<Employee> FindByAge(int from, int to)
        {
            return _employeeContext.Employees.Where(x => x.Age >= from && x.Age <= to);
        }
        public static IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeContext.Employees;
        }
        public static Employee FindLast()
        {
            return _employeeContext.Employees.Last();
        }
    }
}
