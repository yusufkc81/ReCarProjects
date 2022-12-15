using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDTO:IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string FullName { get; set; }
        public DateTime RentTime { get; set; }
        public DateTime ReturnTime { get; set; }
    }
}
