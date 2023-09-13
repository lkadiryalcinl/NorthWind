using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Territory : IEntity
    {
        [Key]
        public int TerritoryId { get; set; }
        public int RegionId { get; set; }
        public string? TerritoryDescription { get; set; }
    }
}
