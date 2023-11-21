using GameProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.DataAccess.Abstracts
{
    public interface IGameDal
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
