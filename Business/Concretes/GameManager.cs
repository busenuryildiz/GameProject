using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstracts;
using GameProject.DataAccess.Abstracts;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Concretes
{
    public class GameManager:IGameService
    {
        IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }
        public void Add(Game game)
        {
            _gameDal.Add(game);
        }

        public void Delete(Game game)
        {
            _gameDal.Delete(game);
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }
    }
}
