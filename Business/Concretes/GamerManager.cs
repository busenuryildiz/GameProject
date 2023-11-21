using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Adapters;
using GameProject.Business.Abstracts;
using GameProject.DataAccess.Abstracts;
using GameProject.DataAccess.Concretes;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Concretes
{
    public class GamerManager : BaseGamerManager
    {
        IGamerDal _gamerDal;
        private IUserValidationService _gamerCheckService;

        public GamerManager(IGamerDal gamerDal,IUserValidationService gamerCheckService)
        {
            _gamerDal=gamerDal;
            _gamerCheckService = gamerCheckService;
        }

        public GamerManager(EfGamerDal efGamerDal, MernisServiceAdapter mernisServiceAdapter)
        {
        }

        public virtual void Add(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                base.Add(gamer);
                Console.WriteLine("Added to db : " + gamer.FirstName);

            }
            else
            {
                throw new Exception("Not a valid person");

            }

        }

        public virtual void Delete(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                base.Delete(gamer);
                Console.WriteLine("Deleted to db : " + gamer.FirstName);

            }
            else
            {
                throw new Exception("Not a valid person");

            }

        }

        public virtual void Update(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                base.Update(gamer);
                Console.WriteLine("Updated to db : " + gamer.FirstName);

            }
            else
            {
                throw new Exception("Not a valid person");

            }

        }
    }
}
