using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureApp.Domain.Abstractions
{
    public abstract class Entity
    {
        public Ulid Id { get; set; }
        public bool  IsActive { get; set; }
        public bool  IsDeleted { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
