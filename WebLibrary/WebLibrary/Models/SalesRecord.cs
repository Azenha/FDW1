using WebLibrary.Models.Enums;

namespace WebLibrary.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double total, SalesStatus status)
        {
            Id = id;
            Date = date;
            Total = total;
            Status = status;
        }
    }
}
