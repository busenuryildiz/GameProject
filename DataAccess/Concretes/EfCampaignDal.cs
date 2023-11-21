using GameProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.DataAccess.Abstracts;

namespace GameProject.DataAccess.Concretes
{
    public class EfCampaignDal : ICampaignDal
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Entity framework kullanılarak {0} eklendi.", campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Entity framework kullanılarak {0}  silindi.", campaign.Name);
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Entity framework kullanılarak {0}  güncellendi.", campaign.Name);
        }
    }
}
