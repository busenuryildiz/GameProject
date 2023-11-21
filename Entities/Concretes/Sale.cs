using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities.Concretes
{
    public class Sale
    {

        public int Id { get; set; }
        public int GamerId { get; set; }
        public int GameId { get; set; }
        public int CampaingId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
    }
}
