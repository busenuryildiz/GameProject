using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities.Concretes
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public string Description { get; set; }
    }
}
