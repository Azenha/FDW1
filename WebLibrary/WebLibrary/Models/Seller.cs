using System.ComponentModel.DataAnnotations;

namespace WebLibrary.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MinLength(3, ErrorMessage = "O Zé era inválido"),MaxLength(28, ErrorMessage = "o limite de caractéres é igual a inconstitucionalissimamente.")]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Salary { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
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
