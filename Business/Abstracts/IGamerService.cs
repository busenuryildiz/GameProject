using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Abstracts
{
    public interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Update(Gamer gamer);
        public void Delete(Gamer gamer);


    }
}
