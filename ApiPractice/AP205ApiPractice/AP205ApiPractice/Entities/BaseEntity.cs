using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP205ApiPractice.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
