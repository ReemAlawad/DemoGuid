namespace DemoGuid.Models
{
    public static class DataInitializer
    {
        public static List<Department> departments = new List<Department>();
        public static List<Department> SeedDepartment()
        {
            departments.Add(new Department { Id = Guid.NewGuid(), Name = "HR" });
            departments.Add(new Department { Id = Guid.NewGuid(), Name = "IT" });
            departments.Add(new Department { Id = Guid.NewGuid(), Name = "Finance" });

            return departments;
        }

        public static List<Employee> SeedEmployee()
        {
            List<Employee> employees = new List<Employee>
    {
        new Employee {Id = Guid.NewGuid(), Name = "John", Position = "Manager", Department = new Department { Name = "HR" } },
        new Employee {Id = Guid.NewGuid(), Name = "Jane", Position = "Staff", Department = new Department { Name = "HR" } },
        new Employee {Id = Guid.NewGuid(), Name = "Doe", Position = "Manager", Department = new Department { Name = "IT" } },
        new Employee {Id = Guid.NewGuid(), Name = "Smith", Position = "Staff", Department = new Department { Name = "IT" } },
        new Employee {Id = Guid.NewGuid(), Name = "Alex", Position = "Manager", Department = new Department { Name = "Finance" } },
        new Employee {Id = Guid.NewGuid(), Name = "Ava", Position = "Staff", Department = new Department { Name = "Finance" } }
    };
            return employees;
        }
    }
}
