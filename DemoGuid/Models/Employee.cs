namespace DemoGuid.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; }
    }
}
