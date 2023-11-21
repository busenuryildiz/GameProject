using GameProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstracts
{
    public interface ICalculateServiceManager
    {
        double CalculatePrice(Game game, Campaign campaign);
    }
}
