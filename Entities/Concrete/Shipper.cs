using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Shipper : IDto
    {
        [Key]
        public int ShipperId { get; set; }
        public string? CompanyName { get; set; }
        public string? Phone { get; set; }
    }
}
