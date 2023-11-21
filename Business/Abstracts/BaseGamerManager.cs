using GameProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstracts
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Added to db : " + gamer.FirstName);

        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to db : " + gamer.FirstName);

        }

        public virtual  void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to db : " + gamer.FirstName);

        }
    }
}
