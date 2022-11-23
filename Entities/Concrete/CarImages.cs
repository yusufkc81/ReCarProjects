using Entities.Abstract;
using System;


namespace Entities.Concrete
{

    public class CarImages : ICar
    {
        
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
