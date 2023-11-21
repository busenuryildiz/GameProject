using GameProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstracts;
using GameProject.DataAccess.Abstracts;

namespace GameProject.Business.Concretes
{
    public class CampaignManager:ICampaignService
    {
        ICampaignDal _campaignDal;


        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }


        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
        }

        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
        }
    }
}
