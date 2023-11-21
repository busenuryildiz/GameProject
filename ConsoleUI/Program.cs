using GameProject.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstracts;
using GameProject.Business.Concretes;
using GameProject.Entities.Concretes;
using GameProject.DataAccess.Abstracts;
using GameProject.DataAccess.Concretes;

namespace GameProject.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new EfGamerDal(), new MernisServiceAdapter());
            gamerManager.Add(new Gamer() { BirthYear = new DateTime(2000, 04, 01), FirstName = "Buse", LastName = "Yıldız", NationalityId = "55555555555" });

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Description = "2024 e kadar geçerli",
                Discount = 25,
                Name = "MUHTEŞEM CUMA"
            };
            CampaignManager campaignManager = new CampaignManager(new EfCampaignDal());
            campaignManager.Add(campaign);


            Game game = new Game()
            {
                Id = 1,
                Name = "GTA 6 ",
                Description = "Tarihin en iyi oyunu",
                UnitPrice = 4000
            };
            GameManager gameManager = new GameManager(new EfGameDal());
            gameManager.Add(game);

            CalculatePriceManager calculatePriceManager = new CalculatePriceManager();


            Sale sale = new Sale
            {
                Id = 1,
                GamerId = 1,
                OrderDate = DateTime.Now,
                CampaingId = 1,
                GameId = 1,
                TotalPrice = calculatePriceManager.CalculatePrice(game, campaign)
            };



            SaleManager saleManager = new SaleManager(new EfSaleDal());
            saleManager.Add(sale);
        }
    }
}
