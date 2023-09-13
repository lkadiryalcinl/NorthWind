using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class EmployeeTerritory : IDto
    {
        public int EmployeeId { get; set; }
        public int TerritoryId { get; set; }
    }
}
