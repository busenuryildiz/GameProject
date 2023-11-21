using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstracts;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Concretes
{
    public class CalculatePriceManager : ICalculateServiceManager
    {
        public double CalculatePrice(Game game, Campaign campaign)
        {
            double newPrice = game.UnitPrice - (game.UnitPrice * (campaign.Discount / 100));
            Console.WriteLine("İndirim uygulandı. \nEski fiyat: " + game.UnitPrice + " \nYeni fiyat:" + newPrice);
            return newPrice;
        }
    }
}
