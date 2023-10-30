using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureApp.Domain.Entities
{
    public sealed class Employee
    {
        public Ulid Id { get;set; }

        public string Name { get; set; }

        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string City { get; set; }
        public string Town { get; set; }
        public string FullAddress { get; set; }

    }

    public enum EmployeeType
    {
        Teacher,
        SchoolPrincipal,
        AssistandPrincipal,
        Janitor,
        Counselor,
        Librarian,
        Nurse,
        CafeteriaWorker,
        SecurityGuard,
        ITSupport,
        AdministrativeStuff
    }

    public sealed class EmployeeWithEmployeeType
    {
        public Ulid EmployeeId { get; set; }
        public EmployeeType EmployeeType { get; set; }
    }
}
