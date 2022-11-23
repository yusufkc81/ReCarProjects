using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : ICar
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RenTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public Boolean Kiralandi { get; set; }
    }
}
