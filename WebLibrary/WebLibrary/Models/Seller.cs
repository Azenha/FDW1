namespace WebLibrary.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, int departmentId)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            DepartmentId = departmentId;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            Sales.Add(salesRecord);
        }
        public void RemoveSales(SalesRecord salesRecord)
        {
            Sales.Remove(salesRecord);
        }
    }
}
