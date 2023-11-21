using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities.Concretes;

namespace GameProject.Business.Abstracts
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
