using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureApp.Domain.Entities
{
    public sealed class SchoolExpense
    {
        public Ulid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }


        public Ulid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
