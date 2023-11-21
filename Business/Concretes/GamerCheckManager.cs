using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Business.Abstracts;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Concretes
{
    public class GamerCheckManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
